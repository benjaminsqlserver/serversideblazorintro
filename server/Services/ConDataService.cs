using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using StudentRegApp.Data;

namespace StudentRegApp
{
    public partial class ConDataService
    {
        private readonly ConDataContext context;
        private readonly NavigationManager navigationManager;

        public ConDataService(ConDataContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportClass1sToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/class1s/excel") : "export/condata/class1s/excel", true);
        }

        public async Task ExportClass1sToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/class1s/csv") : "export/condata/class1s/csv", true);
        }

        partial void OnClass1sRead(ref IQueryable<Models.ConData.Class1> items);

        public async Task<IQueryable<Models.ConData.Class1>> GetClass1S(Query query = null)
        {
            var items = context.Class1s.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnClass1sRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnClass1Created(Models.ConData.Class1 item);

        public async Task<Models.ConData.Class1> CreateClass1(Models.ConData.Class1 class1)
        {
            OnClass1Created(class1);

            context.Class1s.Add(class1);
            context.SaveChanges();

            return class1;
        }
        public async Task ExportGendersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/genders/excel") : "export/condata/genders/excel", true);
        }

        public async Task ExportGendersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/genders/csv") : "export/condata/genders/csv", true);
        }

        partial void OnGendersRead(ref IQueryable<Models.ConData.Gender> items);

        public async Task<IQueryable<Models.ConData.Gender>> GetGenders(Query query = null)
        {
            var items = context.Genders.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnGendersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnGenderCreated(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> CreateGender(Models.ConData.Gender gender)
        {
            OnGenderCreated(gender);

            context.Genders.Add(gender);
            context.SaveChanges();

            return gender;
        }
        public async Task ExportStudentsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/students/excel") : "export/condata/students/excel", true);
        }

        public async Task ExportStudentsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/condata/students/csv") : "export/condata/students/csv", true);
        }

        partial void OnStudentsRead(ref IQueryable<Models.ConData.Student> items);

        public async Task<IQueryable<Models.ConData.Student>> GetStudents(Query query = null)
        {
            var items = context.Students.AsQueryable();

            items = items.Include(i => i.Gender);

            items = items.Include(i => i.Class1);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnStudentsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnStudentCreated(Models.ConData.Student item);

        public async Task<Models.ConData.Student> CreateStudent(Models.ConData.Student student)
        {
            OnStudentCreated(student);

            context.Students.Add(student);
            context.SaveChanges();

            return student;
        }

        partial void OnClass1Deleted(Models.ConData.Class1 item);

        public async Task<Models.ConData.Class1> DeleteClass1(int? classId)
        {
            var item = context.Class1s
                              .Where(i => i.ClassID == classId)
                              .Include(i => i.Students)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnClass1Deleted(item);

            context.Class1s.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnClass1Get(Models.ConData.Class1 item);

        public async Task<Models.ConData.Class1> GetClass1ByClassId(int? classId)
        {
            var items = context.Class1s
                              .AsNoTracking()
                              .Where(i => i.ClassID == classId);

            var item = items.FirstOrDefault();

            OnClass1Get(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.Class1> CancelClass1Changes(Models.ConData.Class1 item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnClass1Updated(Models.ConData.Class1 item);

        public async Task<Models.ConData.Class1> UpdateClass1(int? classId, Models.ConData.Class1 class1)
        {
            OnClass1Updated(class1);

            var item = context.Class1s
                              .Where(i => i.ClassID == classId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(class1);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return class1;
        }

        partial void OnGenderDeleted(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> DeleteGender(int? genderId)
        {
            var item = context.Genders
                              .Where(i => i.GenderID == genderId)
                              .Include(i => i.Students)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnGenderDeleted(item);

            context.Genders.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnGenderGet(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> GetGenderByGenderId(int? genderId)
        {
            var items = context.Genders
                              .AsNoTracking()
                              .Where(i => i.GenderID == genderId);

            var item = items.FirstOrDefault();

            OnGenderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.Gender> CancelGenderChanges(Models.ConData.Gender item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnGenderUpdated(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> UpdateGender(int? genderId, Models.ConData.Gender gender)
        {
            OnGenderUpdated(gender);

            var item = context.Genders
                              .Where(i => i.GenderID == genderId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(gender);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return gender;
        }

        partial void OnStudentDeleted(Models.ConData.Student item);

        public async Task<Models.ConData.Student> DeleteStudent(int? studentId)
        {
            var item = context.Students
                              .Where(i => i.StudentID == studentId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnStudentDeleted(item);

            context.Students.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnStudentGet(Models.ConData.Student item);

        public async Task<Models.ConData.Student> GetStudentByStudentId(int? studentId)
        {
            var items = context.Students
                              .AsNoTracking()
                              .Where(i => i.StudentID == studentId);

            items = items.Include(i => i.Gender);

            items = items.Include(i => i.Class1);

            var item = items.FirstOrDefault();

            OnStudentGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.Student> CancelStudentChanges(Models.ConData.Student item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnStudentUpdated(Models.ConData.Student item);

        public async Task<Models.ConData.Student> UpdateStudent(int? studentId, Models.ConData.Student student)
        {
            OnStudentUpdated(student);

            var item = context.Students
                              .Where(i => i.StudentID == studentId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(student);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return student;
        }
    }
}
