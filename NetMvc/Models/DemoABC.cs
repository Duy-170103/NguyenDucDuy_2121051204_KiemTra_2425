using System.ComponentModel.DataAnnotations;
namespace NetMvc.Models;

public class DemoABC
{
    public int PersonID { get; set; }
    public string Fullname { get; set; }
    public float age { get; set; }
}