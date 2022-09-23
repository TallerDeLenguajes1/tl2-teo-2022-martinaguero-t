namespace EjemploCuentaBancaria;

class Program {

    static int Main(string[] args){

        CuentaCorrientePesos cPesos = new CuentaCorrientePesos(20000,"Juan Perez","34352342");
        cPesos.mostrarInformacionCuenta();
        
        cPesos.Insercion(20000);
        cPesos.mostrarInformacionCuenta();

        cPesos.Extraccion(300000,TipoDeExtraccion.CajeroHumano);

        Console.WriteLine("Creo una lista de cuentas:");

        var lista = new List<Cuenta>();

        lista.Add(cPesos);
        lista.Add(new CuentaDolares(2000,"Sofia Perez","45493482"));
        lista.Add(new CajaAhorroPesos(20000,"José Juarez","43523423"));

        foreach (var cuenta in lista)
        {
            cuenta.mostrarInformacionCuenta();
        }

        Console.ReadLine();

        return 0;
    }
}