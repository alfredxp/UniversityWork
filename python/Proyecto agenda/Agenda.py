'''
Autor: Luis Alfredo Pérez Castillo
Matrícula: 19-1379
Descripción: Agenda telefonica.
'''

import json
Contacts = ()
Program = True


print("""
   _____                             .___            .___       .____          .__            _____  .__   _____                   .___      
  /  _  \    ____   ____   ____    __| _/____      __| _/____   |    |    __ __|__| ______   /  _  \ |  |_/ ____\______   ____   __| _/____  
 /  /_\  \  / ___\_/ __ \ /    \  / __ |\__  \    / __ |/ __ \  |    |   |  |  \  |/  ___/  /  /_\  \|  |\   __\\_  __ \_/ __ \ / __ |/  _ \ 
/    |    \/ /_/  >  ___/|   |  \/ /_/ | / __ \_ / /_/ \  ___/  |    |___|  |  /  |\___ \  /    |    \  |_|  |   |  | \/\  ___// /_/ (  <_> )
\____|__  /\___  / \___  >___|  /\____ |(____  / \____ |\___  > |_______ \____/|__/____  > \____|__  /____/__|   |__|    \___  >____ |\____/ 
        \//_____/      \/     \/      \/     \/       \/    \/          \/             \/          \/                        \/     \/       
""")

with open("Contactsdata.txt") as file:
    Data_Name = file.read()
    Data_Number = json.loads(Data_Name)
    Contacts = Data_Number



    while Program:
        idioma = input("1. Español,  2. Ingles\n")
        if idioma == "1":
            print("1. Todos los contactos. :p \n")
            print("2. Busca un contacto. :>\n")
            print("3. Agrega un contacto. :D\n")
            print("4. Eliminar un contacto. :(\n")
            print("5. Salir de agenda :#\n")

            choice = input("----------->")

            if choice == "1":
                print("Todos tus contactos. :p")
                print("")
                print(Contacts)

            elif choice == "2":
                name = input("Porfavor escribe el nombre del contacto :>\n")
                if name not in Contacts:
                    print("El nombre escrito no se encuentra en la agenda :/")
                else:
                    number = Contacts[name]
                    print(name, ",", number)

            elif choice == "3":
                Name = input("Escribe el nombre del contacto que quieres agregar :D \n")
                Number = input("Escribe su numero: :0\n")
                Contacts[Name] = Number

            elif choice == "4":
                Delete = input("Escribe el nombre del contacto que quieres eliminar :/\n")
                del Contacts[Delete]

            elif choice == "5":
                print("Estas seguro que quieres salir")
                print("1. Continuar, 2. Salir")
                choices = input("Porfavor escribe tu decision")
                if choices == "1":
                    continue
                else:
                    print("Triste de verte ir!")
                    break

        else:
            print("1. All contacts. :p \n")
            print("2. Search for a contact. :>\n")
            print("3. Add a contact. :D\n")
            print("4. Delete contact. :(\n")
            print("5. Exit agenda :#\n")

            choice = input("----------->")

            if choice == "1":
                print("All your contacts. :p")
                print("")
                print(Contacts)

            elif choice == "2":
                name = input("Please type the name of the contact :>\n")
                if name not in Contacts:
                    print("The name searched its not in your agenda :/")
                else:
                    number = Contacts[name]
                    print(name, ",", number)

            elif choice == "3":
                Name = input("Type the name you want to add :D \n")
                Number = input("Type the number of that person: :0\n")
                Contacts[Name] = Number

            elif choice == "4":
                Delete = input("Type the name of the person you want to delete :/\n")
                del Contacts[Delete]

            elif choice == "5":
                print("You sure you want to exit?")
                print("1. Continue, 2. Exit")
                choices = input("Please type your choice")
                if choices == "1":
                    continue
                else:
                    print("Sad to see you go!")
                    break
file.close()

with open("Contactsdata.txt", "w") as file:
    Data_Name = json.dumps(Contacts)
    file.write(Data_Name)
    file.close()

