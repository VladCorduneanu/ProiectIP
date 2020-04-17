Proiect IP
-Prima modificare.
-A doua modificare.

-Lista tools:   -Skype :call-uri, videoconferinta si desktop sharing
		-Github : mentinere git pentru proiect
		-SourceTree : client git
		-VisualStudio 2017 : Mediu de programare
		-Limbaj : C Sharp
		-Trello : Mentinere board cu task-uri
		-FB: Chat
		-Google Drive : Stocare cloud fisiere

Idei proiect:
-Aplicatie de cultura generala -P4 2015 P17 2014
-implementare ca la P1 2014


Resurse:
https://dzone.com/articles/backend-web-api-with-c-step-by-step-tutorial


Idei Implementare:

-Sistem Logare cu useri:Proxy
-Stocarea datelor va fi intr-o baza de date: DAO   Date de stocat:useri, intrabri + raspunsuri, ranking
-Arhitectura MVP-Model View Presenter
-Programare orientata eveniment
-Interfata: Layout Login ->Pagina principala ->Pagina joc: -Intrebarea, Raspunsurile , bara avans, timer, buton exit, buton fifty fifty...->Pagina de final
-Logica jocului: Specifiicatiile: - exista un timer pt fiecare intrebare
				  - 4 raspunsuri la fiecare intrebare, unul corect
				  - optiunea ajutatoare fifty fifty si opinie public : o singura data pe joc
				  - praguri la care te poti opri
				  - se va avansa intre praguri cu fiecare intrebare corecta
				  - daca gresesti o intrebare = Lose
-Impartire pe module: MODEL: -Logare
			     -DAO
			     -GameLogic
		      VIEW: -Logare
			    -Gestionare cont
			    -Scor 
			    -Game
			    -Final
		      PRESENTER: ???

Reguli De programare:
WINDOWS FORMS
-In Windows Forms nu trebuie sa existe elemente cu numele default (din fereastra de creatie a formului)

Coding Guide:
-Proprietatile publice vor avea getter si setter
-proprietati private: _variabila
-proprietati publice: VariabilaPublica
-variabila locala: variabilaLocala
-Interfetele incep cu I : IInterfata
-clasele cu litera mare : Clasa
-parametri functii : parametru
-nume functii : Functie

Loguri:
-"Clasa::Functia : Textul comentariului"

Comentarii:
La inceput Functii: 	/// => 	/// <summary>
        		/// Comentariu Functie
        		/// </summary>
        		/// <returns> Status </returns>

In functie:	/*--> Comentariu <--*/

Nume commit-uri: 
#no.task what has been done to that task    