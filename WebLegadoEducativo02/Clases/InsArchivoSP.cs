using Microsoft.SharePoint.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using File = Microsoft.SharePoint.Client.File;

namespace WebLegadoEducativo02.Clases
{
    public class InsArchivoSP
    {
        Uri web = new Uri("https://udem365.sharepoint.com/sites/Supplementals/");
        private ClientContext context;
        string extension = "";

        public static GridView GridV_Documentos { get; set; }
        public static RadioButtonList rblTipoArchivo { get; set; }
        public static FileUpload FileUpload1 { get; set; }
        public static GridViewRow row { get; set; }

        public static void GuardarArchivo(FileUpload fileUpload, string carpetaDestino)
        {
            if (fileUpload.HasFile)
            {
                string nombreArchivo = Path.GetFileName(fileUpload.FileName);
                string rutaGuardar = HttpContext.Current.Server.MapPath("~/" + carpetaDestino) + nombreArchivo;

                fileUpload.SaveAs(rutaGuardar);
            }
        }

        public static HttpServerUtility Server { get; set; }

        public static void ObtenerServer(HttpServerUtility _server)
        {
            Server = _server;
        }
        public static void ObtenerGrid(GridView _GridV_Documentos)
        {
            GridV_Documentos = _GridV_Documentos;
        }
        protected void file7(string _fullname, string _guidcontactid, string SolicitudId, string quien, string que, string doc)
        {

            string _sharepoinLocationId = string.Empty;
            try
            {
                CrmServiceClient service = null;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

                if (service != null)
                {
                    if (service.IsReady)
                    {

                        Guid GuidSuplemental = Guid.Empty;
                        string _name = "";
                        var carpetaQuery1 = new QueryExpression("new_documentoslegado")
                        {
                            ColumnSet = new ColumnSet("new_documentoslegadoid", "new_name"),
                            Criteria = new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                    {
                       new ConditionExpression("new_contactoid", ConditionOperator.Equal, _guidcontactid),
                      new ConditionExpression("new_registrovigente", ConditionOperator.Equal, true)
                    }
                            }
                        };
                        var carpetaResult1 = service.RetrieveMultiple(carpetaQuery1);
                        if (carpetaResult1.Entities.Count > 0)
                        {
                            foreach (Entity itemEntidad in carpetaResult1.Entities)
                            {
                                GuidSuplemental = itemEntidad.Id;
                                foreach (var dato in itemEntidad.Attributes)
                                {
                                    if (dato.Key == "new_name")
                                    {
                                        _name = ((string)dato.Value);
                                    }
                                }
                            }
                        }

                        QueryExpression _query = new QueryExpression

                        {
                            EntityName = "contact",
                            ColumnSet = new ColumnSet("contactid", "udem_folioudem", "fullname"),
                            Criteria = {
                                         Conditions= {
                                                         new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                                                         new ConditionExpression("contactid", ConditionOperator.Equal, _guidcontactid),
                                                    }
                                        }
                        };
                        Entity oEntidad = service.RetrieveMultiple(_query).Entities.FirstOrDefault();
                        var nombrefull = oEntidad.Attributes.Values;
                        foreach (var itemEntidad in oEntidad.Attributes)
                        {
                            if (itemEntidad.Key == "fullname")
                            {
                                _fullname = (string)itemEntidad.Value;
                            }
                            if (itemEntidad.Key == "contactid")
                            {
                                _guidcontactid = ((Guid)itemEntidad.Value).ToString();
                            }
                        }
                        string carpetaUrl = string.Empty;
                        var carpetaQuery = new QueryExpression("sharepointdocumentlocation")
                        {
                            ColumnSet = new ColumnSet("sharepointdocumentlocationid", "relativeurl", "absoluteurl", "name", "regardingobjectidname", "regardingobjectid", "description", "parentsiteorlocation"),
                            Criteria = new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                    {
                       new ConditionExpression("regardingobjectid", ConditionOperator.Equal, _guidcontactid),
                    }
                            }
                        };
                        var carpetaResult = service.RetrieveMultiple(carpetaQuery);
                        if (carpetaResult.Entities.Count() == 0)
                        {
                            carpetaUrl = _fullname + "_" + _guidcontactid.Replace("-", "");
                        }
                        else
                        {
                            carpetaUrl = carpetaResult.Entities.FirstOrDefault()?.GetAttributeValue<string>("relativeurl");
                            _sharepoinLocationId = carpetaResult.Entities?.FirstOrDefault()?.GetAttributeValue<Guid>("sharepointdocumentlocationid").ToString();
                            //                service.Delete("sharepointdocumentlocation", new Guid(_sharepoinLocationId));
                        }

                        string folder = _name.TrimEnd() + "_" + GuidSuplemental.ToString().Replace("-", "").ToUpper();
                        string folderPath = carpetaUrl + "/" + "new_documentoslegado" + "/" + folder;
                        //            string folderPath = carpetaUrl + "/" + "new_supplementalinformationsubmissionle" + "/" + folder;

                        /////////////////////////////////////////      se incluye codigo nuevo el dia 06}/jul/2023   
                        ///
                        Folder newFolder = null;
                        Web web = context.Web;
                        string listTitle = "Contacto";
                        List documentsList = null;
                        ListCollection lists = web.Lists;
                        context.Load(lists, lc => lc.Include(l => l.Title).Where(l => l.Title == listTitle));
                        context.ExecuteQuery();
                        if (lists.Count > 0)
                        {
                            documentsList = lists.First();
                        }
                        string[] folderSegments = folderPath.Split('/');
                        Folder rootFolder = documentsList.RootFolder;
                        Folder currentFolder = rootFolder;
                        foreach (string folderSegment in folderSegments)
                        {
                            currentFolder = currentFolder.Folders.Add(folderSegment);
                            context.Load(currentFolder);
                            context.ExecuteQuery();
                        }
                        ///////////////////////////////////
                        ///  termina código  nuevo    07/jul/2023
                        ///  
                        newFolder = context.Web.Folders.Add("contact" + "/" + carpetaUrl + "/" + "new_documentoslegado/" + folder);
                        context.ExecuteQuery();

                        string fileName = FileUpload1.FileName;
                        FileCreationInformation newfile = new FileCreationInformation();
                        FileUpload1.SaveAs(Server.MapPath("~/CargaDocumentos/") + FileUpload1.FileName);
                        newfile.Url = System.IO.Path.GetFileName(FileUpload1.FileName);
                        newfile.Url = doc + "_" + que + "_" + quien + extension;
                        //                    newfile.Url = $"{folderPath}/{folder}/{fileName}";
                        newfile.Overwrite = true;
                        string filePath = System.IO.Path.GetDirectoryName(FileUpload1.PostedFile.FileName);
                        newfile.Content = System.IO.File.ReadAllBytes(Server.MapPath("~/CargaDocumentos/") + FileUpload1.FileName);
                        File uploadFile = newFolder.Files.Add(newfile);
                        context.Load(uploadFile);
                        context.ExecuteQuery();
                        FileInfo fileinfo = new FileInfo(Server.MapPath("~/CargaDocumentos/") + FileUpload1.FileName);
                        long fileSize = fileinfo.Length;
                        string fileSizeInKb = (fileSize / 1024).ToString("0.00") + " Kb ";
                        string fileSizeinMb = (fileSize / 1024 / 1024).ToString("000.00") + " Mb ";

                        if (carpetaResult.Entities.Count() == 0)
                        {
                            string absoluteFileUrl = uploadFile.ServerRelativeUrl;
                            Entity sharepointDocumentLocation = new Entity("sharepointdocumentlocation");
                            sharepointDocumentLocation.Attributes["relativeurl"] = carpetaUrl;
                            //                                sharepointDocumentLocation.Attributes["absoluteurl"] = absoluteFileUrl;
                            sharepointDocumentLocation.Attributes["name"] = fileName;
                            EntityReference regardingObjectReference = new EntityReference("contact", new Guid(_guidcontactid));
                            sharepointDocumentLocation.Attributes["regardingobjectid"] = regardingObjectReference;
                            Guid sharepointDocumentLocationId = service.Create(sharepointDocumentLocation);
                        }

                        EntityReference recorRef = new EntityReference("contact", new Guid(_guidcontactid));
                        Entity attachement = new Entity("annotation");
                        attachement.Attributes["filename"] = "Matricula" + "ActaNacimiento" + extension;
                        attachement.Attributes["documentbody"] = Convert.ToBase64String(newfile.Content);
                        attachement.Attributes["objectid"] = recorRef;
                        attachement.Attributes["objecttypecode"] = "contact";
                        Guid recordIdannotation = service.Create(attachement);
                    }
                }
                // Resto de tu código utilizando el servicio CRM
            }
            catch (Exception ex)
            {
                // Manejar la excepción, mostrar un mensaje de error, registrar en el registro, etc.
            }


        }

        public void SubirArchivo(int index, string _fullname, string _guidcontactid, string SolicitudId, string quien, string que, string doc)
        {
            row = GridV_Documentos.Rows[index];
            rblTipoArchivo = (RadioButtonList)row.FindControl("Rbl_TipoArchivo");
            FileUpload1 = (FileUpload)row.FindControl("file_upload");
            WACargaArchivoSP.AuthenticationManager auten = new WACargaArchivoSP.AuthenticationManager();
            context = auten.GetContext(web, "soportecrm5@udem.edu", "2023Udem$");
            extension = Path.GetExtension(FileUpload1.FileName);

            try
            {
                if (FileUpload1.HasFile)
                {
                    if (extension == ".pdf" || extension == ".jpg" || extension == ".png" || extension == ".png")
                    {
                        file7(_fullname, _guidcontactid, SolicitudId, quien, que, doc);
                    }
                    else
                    {
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();
            }
        }
    }
}