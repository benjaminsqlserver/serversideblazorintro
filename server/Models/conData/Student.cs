using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegApp.Models.ConData
{
  [Table("Students", Schema = "dbo")]
  public partial class Student
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentID
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
    public string MiddleName
    {
      get;
      set;
    }
    public string Surname
    {
      get;
      set;
    }
    public int GenderID
    {
      get;
      set;
    }
    public Gender Gender { get; set; }
    public string Photo
    {
      get;
      set;
    }
    public int CurrentClassID
    {
      get;
      set;
    }
    public Class1 Class1 { get; set; }
  }
}
