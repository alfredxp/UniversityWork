'''
Autor: Luis Alfredo Pérez Castillo
Matrícula: 19-1379
Descripción: Programa que simule un cajero automatico
'''

print("Bienvenido al cajero automatico")

import csv
import sys


validacion = False
Usuario = []
operacion = True
Numero = []
intentos = 0
Pin = []
oportunidad = 0
Balance = []



with open("cajero_datos.txt") as datos_cuentas:
    informacion = csv.DictReader(datos_cuentas)
    for row in informacion:
        Usuario.append(row["Usuario"])
        Numero.append(row["Numero"])
        Pin.append(row["Pin"])
        Balance.append(row["Balance"])


user = input("Favor de introducir su numero de cuenta\n")
while user not in Numero:
    oportunidad = 0
    print("El usuario digitado no existe.")
    print("\n")
    print("Favor introducir el número de cuentas nuevamente\n")

if user == Numero[oportunidad]:
    print("Acceso garantizado!")
    operacion == True

else:
    
    oportunidad +=1
    if (user == Numero[oportunidad]):
        print("Acceso garantizado!")
        operacion = True
while (operacion == True) and (intentos <= 3):
    intentos += 1

    contrasena = int(input("Introduzca su Pin\n"))
    if contrasena == int(Pin[oportunidad]):
        print("1. CONSULTA DE BALANCE")
        print("2. DEPOSITO")
        print("3. RETIRO")
        print("4. SALIR")

        opcioncuenta = input("--->")
        
            

        if opcioncuenta == "1":
            print("Usted posee: ", Balance[oportunidad], "$ pesos")
            break

        elif opcioncuenta == "2":
            depositoc = int(input("Indique la cantidad a depositar:\n"))
            deposito = int(Balance[oportunidad]) + int(depositoc)
            print(f"Su nuevo balance es de {deposito} $ pesos")
            Balance_actualizado = deposito
            Balance[oportunidad] = Balance_actualizado
            break

        elif opcioncuenta == "3":
            retiroe = int(input("Indique la cantidad a retirar:\n"))
            if retiroe > int(Balance[oportunidad]):
                print("No posee balance para retirar ")
            else:
                dinero = int(Balance[oportunidad]) - int(retiroe)
                print(f"Su nuevo balance es de {dinero} $ pesos")
                Balance_de_retiro = dinero
                Balance[oportunidad] = Balance_de_retiro
                print (Balance[oportunidad])
                break
        elif opcioncuenta == "4":
            break

    elif contrasena != Pin[oportunidad]:
        print("El pin introducido es invalido")
    else:
        print("Usted no tiene mas intentos")
        operacion = False

datos_cuentas.close()



valores = [
    ["Usuario","Numero","Pin","Balance"],
    [Usuario[0],Numero[0],Pin[0],Balance[0]],
    [Usuario[1],Numero[1],Pin[1],Balance[1]],
    [Usuario[2],Numero[2],Pin[2],Balance[2]],
    [Usuario[3],Numero[3],Pin[3],Balance[3]],
]




with open('cajero_datos.txt',"w",newline= "") as datos:
    escribir = csv.writer(datos, delimiter=",")
    escribir.writerows(valores)

datos.close()