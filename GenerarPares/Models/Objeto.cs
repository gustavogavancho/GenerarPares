using System.ComponentModel.DataAnnotations;

namespace GenerarPares.Models;

public class Objeto
{
    [Range(50, 500, ErrorMessage = "El número ingresado debe estar entre 50 y 500")]
    public int Numero { get; set; }
    public string Resultado { get; set; }
}