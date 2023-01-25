"""
Autor: Luis Alfredo Pérez Castillo
Matrícula: 19-1379
Descripción: Hangman
"""

import random
import os
import json


wordslist = ()
words = []
writtenwords = []
intentos = 0

soga  = ["   -----------|",
		    "/                      ",
		    "|                      ",
		    "|                      ",
			"|                      ",
			"|                      ",
		    "|                      ",]

personita1 = [" -------|",
		     "/         O           ",
		     "|         |            ",
		     "|         |            ",
			 "|         |           ",
			 "|                     ",
		     "|                     ",]
personita2 = [" -------|",
		     "/         O           ",
		     "|         |           ",
		     "|         |           ",
			 "|         |           ",
			 "|        / \          ",
		     "|       /   \         ",]
personita3 = [" -------|",
		     "/         O           ",
		     "|       \ | /         ",
		     "|        \|/          ",
			 "|         |           ",
			 "|        / \          ",
		     "|       /   \         ",]

with open("ahorcado_lista.txt") as file:
	data = file.read()
	data_full = json.loads(data)
	fulllist = data_full

while True:
	noformatword = random.choice(fulllist)
	word = noformatword.upper()

	print("""
___________.__           .__                                     .___       ___.           .____          .__            _____  .__   _____                   .___      
\_   _____/|  |   _____  |  |__   ___________   ____ _____     __| _/____   \_ |__ ___.__. |    |    __ __|__| ______   /  _  \ |  |_/ ____\______   ____   __| _/____  
 |    __)_ |  |   \__  \ |  |  \ /  _ \_  __ \_/ ___\\__  \   / __ |/  _ \   | __ <   |  | |    |   |  |  \  |/  ___/  /  /_\  \|  |\   __\\_  __ \_/ __ \ / __ |/  _ \ 
 |        \|  |__  / __ \|   Y  (  <_> )  | \/\  \___ / __ \_/ /_/ (  <_> )  | \_\ \___  | |    |___|  |  /  |\___ \  /    |    \  |_|  |   |  | \/\  ___// /_/ (  <_> )
/_______  /|____/ (____  /___|  /\____/|__|    \___  >____  /\____ |\____/   |___  / ____| |_______ \____/|__/____  > \____|__  /____/__|   |__|    \___  >____ |\____/ 
        \/             \/     \/                   \/     \/      \/             \/\/              \/             \/          \/                        \/     \/       
""")

	while True:
		tries = input("Introduzca el número de intentos, (3 es lo recomendable)\n")
		if not tries.isdigit():
			print("Debes escribir un número de intentos")
		else:
			break

	digit = float(tries)
	intentos_count = (3/digit)
	while True:
		print(intentos)
		if intentos >=3:
			print(personita3)
		elif intentos >=2:
			print(personita2)
		elif intentos >=1:
			print(personita1)
		result = ""

		for letter in word:
			if letter in words:
				result += letter
			else:
				result += "_"


		print(" ".format(result))

		if result == word:
			print("Introduciste la palabra correcta!")
			words = []
			writtenwords = []
			noformatword = ''
			word = ''
			intentos = 0
			break
		if intentos >= 3:
			print("Haz perdido!")
			words = []
			writtenwords = []
			noformatword = ''
			word = ''
			intentos = 0
			break

		while True:
			word_user = input("Digite una letra: \n")
			user_word = word_user.upper()

			if user_word in writtenwords:
				print("Escribe otra letra")
			elif len(user_word) > 1 or len(user_word) > 1:
				print("Escribe mas de una letra")
			elif not user_word.isalpha():
				print("Escribe una letra")
			else:
				writtenwords += user_word
				break

		if user_word not in word:
			intentos += intentos_count
		else:
			writtenwords += user_word





