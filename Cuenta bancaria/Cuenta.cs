namespace EjemploCuentaBancaria;
public abstract class Cuenta {

    public abstract void Insercion(int monto);
    public abstract void Extraccion(int monto, TipoDeExtraccion tipo);

    protected double montoCuenta;
    private string nombreTitular;
    private string DNITitular;
    public Cuenta(double montoCuenta, string nombreTitular, string DNITitular){
        this.montoCuenta = montoCuenta;
        this.nombreTitular = nombreTitular;
        this.DNITitular = DNITitular;
    }

    public virtual void mostrarInformacionCuenta(){
        Console.WriteLine($"==> CUENTA DE: {this.nombreTitular}, DNI {this.DNITitular}");
    }

    public double getMontoCuenta() {
       return this.montoCuenta; 
    } 

}

public class CuentaCorrientePesos : Cuenta {

    public override void Insercion(int monto){
        this.montoCuenta += monto;
    }
    public override void Extraccion(int monto, TipoDeExtraccion tipo){
        if(this.montoCuenta - monto < 5000) {
            Console.WriteLine("No se puede extraer. Fondos insuficientes.");
        } else {
            if(tipo == TipoDeExtraccion.CajeroHumano){
                this.montoCuenta -= monto;
            } else {
                if(monto > 20000) Console.WriteLine("No se puede extraer ese monto por ATM."); else this.montoCuenta -= monto;
            }
        }
    }

    public override void mostrarInformacionCuenta(){
        base.mostrarInformacionCuenta();
        Console.WriteLine($" -> CUENTA CORRIENTE EN ARS");
        Console.WriteLine($" -> Monto: {this.getMontoCuenta()} ARS");
    }

    public CuentaCorrientePesos(double montoCuenta, string nombreTitular, string DNITitular) : base(montoCuenta,nombreTitular,DNITitular){
         
    }
    

}

public class CuentaDolares : Cuenta {

    public override void Insercion(int monto){
        this.montoCuenta += monto;
    }
    public override void Extraccion(int monto, TipoDeExtraccion tipo){
        if(monto > this.montoCuenta) {
            Console.WriteLine("No se puede extraer. Fondos insuficientes.");
        } else {
            if(tipo == TipoDeExtraccion.CajeroHumano){
                this.montoCuenta -= monto;
            } else {
                if(monto > 200) Console.WriteLine("Monto diario de extracción alcanzado."); else this.montoCuenta -= monto;
            }
        }
    }

    public override void mostrarInformacionCuenta(){
        base.mostrarInformacionCuenta();
        Console.WriteLine($" -> CUENTA CORRIENTE EN USD");
        Console.WriteLine($" -> Monto: {this.getMontoCuenta()} USD");
    }
    
    public CuentaDolares(double montoCuenta, string nombreTitular, string DNITitular) : base(montoCuenta,nombreTitular,DNITitular){
         
    }
}

public class CajaAhorroPesos : Cuenta {
    public override void Insercion(int monto){
        this.montoCuenta += monto;
    }
    public override void Extraccion(int monto, TipoDeExtraccion tipo){
        if(monto > this.montoCuenta) {
            Console.WriteLine("No se puede extraer. Fondos insuficientes.");
        } else {
            if(tipo == TipoDeExtraccion.CajeroHumano){
                this.montoCuenta -= monto;
            } else {
                if(monto > 10000) Console.WriteLine("No se puede extraer ese monto por ATM."); else this.montoCuenta -= monto;
            }
        }
    }

    public override void mostrarInformacionCuenta(){
        base.mostrarInformacionCuenta();
        Console.WriteLine($" -> CAJA DE AHORRO EN PESOS");
        Console.WriteLine($" -> Monto: {this.getMontoCuenta()} ARS");
    }

    public CajaAhorroPesos(double montoCuenta, string nombreTitular, string DNITitular) : base(montoCuenta,nombreTitular,DNITitular){
         
    }
}