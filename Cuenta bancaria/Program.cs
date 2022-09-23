namespace EjemploCuentaBancaria;

class Program {

    static int Main(string[] args){

        CuentaCorrientePesos cPesos = new CuentaCorrientePesos(20000,"Juan Perez","34352342");
        cPesos.mostrarInformacionCuenta();
        
        cPesos.Insercion(20000);
        cPesos.mostrarInformacionCuenta();

        cPesos.Extraccion(300000,TipoDeExtraccion.CajeroHumano);

        Console.ReadLine();

        return 0;
    }
}