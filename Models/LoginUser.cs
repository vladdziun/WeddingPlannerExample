using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class LoginUser
{
    [Required]
    public string LoginEmail {get; set;}
    [DataType(DataType.Password)]
    [Required]
    public string LoginPassword { get; set; }
}