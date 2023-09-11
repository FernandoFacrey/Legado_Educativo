using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLegadoEducativo02.ClasesWS
{
    public class CatalogosCRM
    {
        public Guid getExisteOport(IOrganizationService service, Guid Opport)
        {
            Guid id = Guid.Empty;
            #region _query
            QueryExpression _query = new QueryExpression
            {
                EntityName = "opportunity",
                ColumnSet = new ColumnSet("recr_nveldeinteres", "parentcontactid"),
                Criteria = {
                                                    Conditions= {             
                                                    new ConditionExpression("parentcontactid", ConditionOperator.Equal, Opport),
                                                    new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                                                    }
                                                }
            };
            #endregion
            EntityCollection oEntidad = service.RetrieveMultiple(_query);
            if (oEntidad.Entities.Count > 0)
            {
                foreach (Entity itemEntidad in oEntidad.Entities)
                {

                    if (itemEntidad.Attributes.Contains("opportunityid"))
                    {
                        id = ((Guid)itemEntidad.Attributes["opportunityid"]);
                    }
                }
            }
            return id;
        }
    }
}