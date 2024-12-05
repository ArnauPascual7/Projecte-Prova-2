# Projecte-Prova-2

**Arnau Pascual**

# ✤ Enunciat

### 1. Detalla el càlcul del mètode recursiu següent pels valors de num indicats, tal com hem fet a classe. Quina funcionalitat executa el mètode? (2 punts):

- num = 2
- num = 12

        public static int RecMethod(int num)
        {
            int total = 0;

            if (num < 10) return num;

            while (num > 0)
            {
                    total += num % 10;
                    num /= 10;
            }

            return RecMethod(total);
        }

#### **num = 2**

Quan cridem la funció RecMethod amb num = 2, on s'inicialitza la variable total a 0, i després com que num és menor que 10 la funció retorna num altre cop i acaba la funció.

#### **num = 12**

Quan cridem la funció RecMethod amb num = 12, on s'inicialitza la variable total a 0, i després com que num és major que 10 no entrem en la condició i al continuar trobem un while. En el while com que num és major a 0 entrem dins d'aquest. Dins del bucle total serà igual a total més el mòdul de 10, que és 0, després num és igual a num entre 2 i tornem a començar el bucle, el bucle continuarà fins que num sigui igual o menor a 0. Quan num és 0 contniua l'execusió de la funció, que retorna la mateixa funció, però aquesta vegada en comptes de cridar-la amb num, la cridem a total. Quan cridem de nou la funció total, ara converitit amb el nou num per la funció, ja és menor que 10, així que retornem num i acaba la funció.

### 2. Implementa un programa senzill, fent servir la llibreria més adient en cada cas d’entre les que trobaràs en aquest [enllaç](https://drive.google.com/drive/folders/1mOf7DHD8PWdf31kYrsEis6n1ubpsnQj4?usp=sharing), que:
- demani un valor enter a l'usuari per teclat i aquest retorni si es troba o no a la llista següent:
 { 10, -4, 6, 4, 8, 13, 2, -4} (1,5 punts)
- mostri la llista de valors anterior (apartat a) ordenada de manera ascendent (1,5 punts)
Argumenta quines llibreries has fet servir i per què. En cas que no es faci servir cap de les llibreries de l’enllaç indicat, la solució NO comptarà com a vàlida.

Argumenta quines llibreries has fet servir i per què. En cas que no es faci servir cap de les llibreries de l’enllaç indicat, la solució NO comptarà com a vàlida.

a

### 3. Analitza el següent [codi](https://drive.google.com/file/d/1_Wl23nwWRNy6ZR1bnZCzH-IraeYjpSb4/view?usp=sharing) i reescriu el programa, aplicant els mètodes de refacció i optimització i validant que aquest funcioni correctament i faci allò que s’indica a la postcondició (2 punts).

a

### 4. A partir d'una màquina senzilla que pot executar 4 operacions (2 punts):

        CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11

Tradueix a llenguatge de baix nivell les següents instruccions, indicant la instrucció sencera (de 16 bits) en format binari que ha d’executar la màquina:

A10, B11, C12, D13, E14, F15

- **CMP 2F, 35** ->
- **MOV AB, 74** ->
- **ADD 12, 43** ->
- **MOV A8, 66** ->

***Important!! Totes les adreces de memòria estan en base hexadecimal.***

### 5. Desenvolupa un programa que demani 20 valors enters a l'usuari i:

- mostri aquesta llista de valors ordenada de manera ascendent, implementant l’algorisme bubble sort (2 punts).
- demani un valor enter a l’usuari i informi per consola si aquest es troba entre els valors introduïts o no (2 punts).

a

### 6. L'empresa on estàs fent pràctiques es dedica a desenvolupar jocs de taula digitals. Formes part de l'equip encarregat de la nova versió del famós joc "Escape the Dungeon". En aquest sprint, una de les tasques és implementar un sistema de validació per una contrasenya màgica que permeti desbloquejar el cofre que conté la clau per escapar del calabós.

La contrasenya màgica ha de complir les següents restriccions:

- Ha de tenir entre 5 i 12 caràcters (inclosos).
- Només pot contenir lletres i números (a-z, A-Z, 0-9).
- No pot començar ni acabar amb un número.

El teu objectiu és:
- escriure els tests necessaris per validar tots els casos (indicant en el mateix test les classes d’equivalència, valors límit i casos de prova). Es pot fer servir MsTest o XUnit (2 punts).
- implementar una funció en C# que comprovi si una contrasenya és vàlida segons les normes anteriors i executar els tests, validant que els resultats són correctes (2 punts).

a