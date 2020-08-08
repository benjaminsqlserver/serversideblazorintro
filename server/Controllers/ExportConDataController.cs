using Microsoft.AspNetCore.Mvc;
using StudentRegApp.Data;

namespace StudentRegApp
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }

        [HttpGet("/export/ConData/class1s/csv")]
        public FileStreamResult ExportClass1sToCSV()
        {
            return ToCSV(ApplyQuery(context.Class1s, Request.Query));
        }

        [HttpGet("/export/ConData/class1s/excel")]
        public FileStreamResult ExportClass1sToExcel()
        {
            return ToExcel(ApplyQuery(context.Class1s, Request.Query));
        }

        [HttpGet("/export/ConData/genders/csv")]
        public FileStreamResult ExportGendersToCSV()
        {
            return ToCSV(ApplyQuery(context.Genders, Request.Query));
        }

        [HttpGet("/export/ConData/genders/excel")]
        public FileStreamResult ExportGendersToExcel()
        {
            return ToExcel(ApplyQuery(context.Genders, Request.Query));
        }

        [HttpGet("/export/ConData/students/csv")]
        public FileStreamResult ExportStudentsToCSV()
        {
            return ToCSV(ApplyQuery(context.Students, Request.Query));
        }

        [HttpGet("/export/ConData/students/excel")]
        public FileStreamResult ExportStudentsToExcel()
        {
            return ToExcel(ApplyQuery(context.Students, Request.Query));
        }
    }
}
