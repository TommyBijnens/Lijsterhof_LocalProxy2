using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class CVParameterService
    {
        public const bool canWrite = true;
        public static Dictionary<string, CVParameter> parameterDictionary()
        {
            return new Dictionary<string, CVParameter>(StringComparer.OrdinalIgnoreCase)
            {
               {"temp1", new CVParameter("Temperatuur 1",1,1, Parameter.DisplayType.Textbox)},
               {"temp2", new CVParameter("Temperatuur 2",1,2, Parameter.DisplayType.Textbox)},
               {"temp3", new CVParameter("Temperatuur 3",1,3, Parameter.DisplayType.Textbox)},
               {"tempBuffer", new CVParameter("Temperatuur Buffer",1,4, Parameter.DisplayType.Textbox)},
               {"setup1", new CVParameter("Water temperatuur setting",1,5, Parameter.DisplayType.Numericbox, canWrite)},
               {"setup2", new CVParameter("Buffer temperatuur setting",1,8, Parameter.DisplayType.Numericbox, canWrite)},
               {"tempBoilerBS", new CVParameter("Boiler Bruno & Sandy",1,6, Parameter.DisplayType.Textbox)},
               {"tempBoilerT", new CVParameter("Boiler Tommy",1,7, Parameter.DisplayType.Textbox)},

               {"pump1", new CVParameter("Bruno & Sandy - Pomp 1 - Warm water",2,1, Parameter.DisplayType.Pump)},
               {"pump2", new CVParameter("Bruno & Sandy - Pomp 2 - Verwarming",2,2, Parameter.DisplayType.Pump)},
               {"pump3", new CVParameter("Tommy - Pomp 1 - Warm water",2,3, Parameter.DisplayType.Pump)},
               {"pump4", new CVParameter("Tommy - Pomp 2 - Verwarming",2,4, Parameter.DisplayType.Pump)},

               {"pumpMain", new CVParameter("Hoofdpomp",3,1, Parameter.DisplayType.Pump)},
               {"oilHeating", new CVParameter("Mazoutketel in werking",3,2, Parameter.DisplayType.Switch)},
               {"oilSelected", new CVParameter("Mazoutketel actief",3,3, Parameter.DisplayType.Switch)},
               {"woodHeating", new CVParameter("Houtketel in werking",3,4, Parameter.DisplayType.Switch)},
               {"woodSelected", new CVParameter("Houtketel actief",3,5, Parameter.DisplayType.Switch)},

               {"counterWoodBS", new CVParameter("Teller B&S hout",4,1, Parameter.DisplayType.Textbox)},
               {"counterOilBS", new CVParameter("Teller B&S mazout",4,2, Parameter.DisplayType.Textbox)},
               {"counterTotalBS", new CVParameter("Teller B&S totaal",4,3, Parameter.DisplayType.Textbox)},
               {"counterWoodT", new CVParameter("Teller T hout",4,4, Parameter.DisplayType.Textbox)},
               {"counterOilT", new CVParameter("Teller T mazout",4,5, Parameter.DisplayType.Textbox)},
               {"counterTotalT", new CVParameter("Teller T totaal",4,6, Parameter.DisplayType.Textbox)},

               {"dayCounterWoodBS", new CVParameter("Dagteller B&S hout",5,1, Parameter.DisplayType.Textbox)},
               {"dayCounterOilBS", new CVParameter("Dagteller B&S mazout",5,2, Parameter.DisplayType.Textbox)},
               {"dayCounterTotalBS", new CVParameter("Dagteller B&S totaal",5,3, Parameter.DisplayType.Textbox)},
               {"dayCounterWoodT", new CVParameter("Dagteller T hout",5,4, Parameter.DisplayType.Textbox)},
               {"dayCounterOilT", new CVParameter("Dagteller T mazout",5,5, Parameter.DisplayType.Textbox)},
               {"dayCounterTotalT", new CVParameter("Dagteller T totaal",5,6, Parameter.DisplayType.Textbox)},

               {"BS_CV_M", new CVParameter("B&S - Verwarming op mazout",6,1, Parameter.DisplayType.Switch, canWrite)},
               {"BS_CV_H", new CVParameter("B&S - Verwarming op hout",6,2, Parameter.DisplayType.Switch,canWrite)},
               {"BS_WW_M", new CVParameter("B&S - Warm water op mazout",6,3, Parameter.DisplayType.Switch,canWrite)},
               {"BS_WW_H", new CVParameter("B&S - Warm water op hout",6,4, Parameter.DisplayType.Switch,canWrite)},
               {"T_CV_M", new CVParameter("T - Verwarming op mazout",6,5, Parameter.DisplayType.Switch, canWrite)},
               {"T_CV_H", new CVParameter("T - Verwarming op hout",6,6, Parameter.DisplayType.Switch, canWrite)},
               {"T_WW_M", new CVParameter("T - Warm water op mazout",6,7, Parameter.DisplayType.Switch, canWrite)},
               {"T_WW_H", new CVParameter("T - Warm water op hout",6,8, Parameter.DisplayType.Switch, canWrite)},

            };
        }
    }
}