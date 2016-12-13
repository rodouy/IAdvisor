using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Utilities;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisorConsole.Insert._02_Language
{
    public static class LanguageInsert
    {

        #region Language

        public static void InsertLanguages()
        {
            var lBase = new Language
            {
                Name = Utils.NameBase,
            };

            var lSpanish = new Language
            {
                Name = Utils.NameLanguageSpanish,
            };

            var lEnglish = new Language
            {
                Name = Utils.NameLanguageEnglish,
            };

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Languages.Add(lBase);
                context.Languages.Add(lSpanish);
                context.Languages.Add(lEnglish);
                context.SaveChanges();
            }
        }

        #endregion

    }
}
