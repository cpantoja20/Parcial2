using System;

namespace Entity
{
    public class Empresas
{
public string IdEmpresa { get; set; }
public string NEmpresa { get; set; }
public int CEmpleados { get; set; }
public decimal VrActivos { get; set; }
public string TipoEmpresa { get; set; }
public string CreditoEmpresa { get; set; }

public void CalcularTipoEmpresa()
{
if (CEmpleados.Equals("F") || Sexo.Equals("f"))
{
Pulsacion=(220 - Edad) / 10;
}
else
{
Pulsacion=(210 - Edad) / 10;
}
}
}
}