using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegApp.Models.ConData
{
  [Table("Classes", Schema = "dbo")]
  public partial class Class1
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ClassID
    {
      get;
      set;
    }

    public ICollection<Student> Students { get; set; }
    public string ClassName
    {
      get;
      set;
    }
  }
}
