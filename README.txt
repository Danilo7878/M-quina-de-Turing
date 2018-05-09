2do Proyecto de Lenguajes formales y aut�matas. 
M�quinas de Turing.

Danilo Sandoval 1167216.

funcionamiento:
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

El programa presentado es bastante sencillo e intuitivo:
Muestra un panel donde, puede elegir una de las 5 simulaciones de m�quinas de turing.
simplemente debe escribir su cadena ya sea que tenga un formato correcto o no, pues las mismas transiciones
se encargaran de rechazarla, si no se ingresa una cadena v�lida, o se ingresa un caracter no definido en el
lenguaje para los caracteres de entrada.
Una vez ingresada la cadena, se muestra la cinta y el cabezal, y usted puede proceder a ejecutar la simulaci�n
donde se muestra cada transici�n (movimiento del cabezal recorriendo la cinta, y el estado actual).
Tambi�n puede modificar el tiempo entre transiciones.

****(puede consultar el manual de usuario para conocer con m�s detalle su funcionamiento)****
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


Robusto:
----------------------------------------------------------------------------------------------------------------
El programa y su interfaz est�n bastante bien manejados e implementados, 
a modo de evitar que se rompa el programa por un mal uso.
----------------------------------------------------------------------------------------------------------------
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

Todas las m�quinas de turing fueron definidas e implementadas bajo los criterios establecidos en el curso:

- Utiliza �nicamente cintas semi-infinitas, si el cabezal intentara ir a la izquierda de la posici�n inicial
la m�quina se detiene, sin validar la cadena ni el proceso.
- Si en determinado estado el cabezal lee un caracter no definido, la m�quina se detiene a medio proceso
haciendo no v�lida la entrada.
- La entrada solo es v�lida, si la m�quina entra en un estado de aceptaci�n, esta autom�ticamente se detiene.

---------------------------------------------------------------------------
-Las m�quinas de turing est�n definidas con algunos procesos que parecen redundantes, pues m�s adelante se utilizan estados con casi las mismas transiciones, esto debido a que las primeras transiciones y estados, no s�lo inician con el proceso u operaci�n, tambi�n se encarga de verificar (seg�n los criterios anteriores) que la entrada est� un formato correcto
y no tenga s�mbolos no definidos en el lenguaje, o bien sena s�mbolos utilizados por la m�quina para el proceso de una operaci�n y altere el funcionamiento de la m�quina, escribiendo esos mismos s�mbolos directamente en la cinta, �uego de la verificaci�n, la m�quina puede seguir el resto de su camino tranquila, realizando los mismos procesos, utilizando s�mbolos de m�quina, sin la preocupaci�n de encontrarse con fallos debido a lo anteriormente mencionado.

************************************************************************************************************************
En el caso de la m�quina que analiza si una cadena es pal�ndromo, se tuvo el cuidado de aceptar un pal�ndromo, as� este fuera par o impar, adem�s, a pesar de usar s�mbolos para remplazo de los caracteres e ir marcando los ya analizados, una vez utilizados, se van desmarcando, de modo que si la cadena es aceptada como pal�ndromo, al final la cinta muestra la cadena justo como estaba.
*************************************************************************************************************************
En la copia de patrones, se tomaron las mismas precauciones, pues todas las m�quinas definidas en el programa usan s�mbolos de m�quina, y se hacen verificaciones dentro de la misma definici�n de la m�quina de no causar conflicto ingrsando estos s�mbolos en la cinta.
a pesar de la utilizaci�n de estos s�mbolos, justo como deber�a ser la cinta muestra la cadena duplicada justo como fue escrita.
*************************************************************************************************************************
En las que ejecutan operaciones en binario se tomaron en cuenta las siguientes consideraciones:

- se utiliza como s�mbolo representativo del sistema, al n�mero "1"
- se debe ingresar valor, signo, valor, y signo de igual (ejemplo 1111*111=)
- la respuesta se mostrar�a de la siguiente manera: 1111*111=111111111111
- siendo que el sistema unario, repesenta n�meros naturales, no hay forma de representar al cero, ni a los n�mero negativos, por tanto no hay forma de ingresarlos (hacer"11+=") no va a sumar 2+0, simplemente no lo va a aceptar.
-bajo el mismo criterio, las operaciones (espec�ficamente la resta) tampoco puede restar n�meros que den de resultado negativo o cero, (restar dos n�mero iguales, o restarle un n�mero mayor a otro n�mero), la m�quina rechazar�a esto: 
"11-11=" y esto "111-111111="
- los estados y transiciones toman en consideraci�n, que no se puedan repetir signos, no puedo hacer esto:
"111--11=", ni esto: "11-1==" de es modo tambi�n sabemos que solo son 2 n�meros por operaci�n (es decir no se puede hacer esto 111+11+1=).

como dije antes en todas las m�quinas se toman las precauciones del ingreso de s�mbolos de cinta, la m�quina est� definida para rechazarlos desde el principio (a nivel de definici�n y no de programaci�n) y que no cause confuci�n en las operaciones.

(lo hice sencillo pero si me esforc� en cumplir con todos los requerimientos)

�ESPERO EL PROYECTO, SEA DE SU AGRADO!



