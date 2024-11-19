// See https://aka.ms/new-console-template for more information
using CodigoClase_06_11_2024;

Cuenta cuenta1 = new CuentaCorriente(new Euros());
Cuenta cuenta2 = new CuentaCorriente(new Dolares());
Cuenta cuenta3 = new CuentaAhorros(new Dolares());

cuenta1.CrearCuenta();
cuenta2.CrearCuenta();
cuenta3.CrearCuenta();

