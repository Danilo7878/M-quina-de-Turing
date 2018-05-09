2do Proyecto de Lenguajes formales y autómatas. 
Máquinas de Turing.

Danilo Sandoval 1167216.

funcionamiento:
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

El programa presentado es bastante sencillo e intuitivo:
Muestra un panel donde, puede elegir una de las 5 simulaciones de máquinas de turing.
simplemente debe escribir su cadena ya sea que tenga un formato correcto o no, pues las mismas transiciones
se encargaran de rechazarla, si no se ingresa una cadena válida, o se ingresa un caracter no definido en el
lenguaje para los caracteres de entrada.
Una vez ingresada la cadena, se muestra la cinta y el cabezal, y usted puede proceder a ejecutar la simulación
donde se muestra cada transición (movimiento del cabezal recorriendo la cinta, y el estado actual).
También puede modificar el tiempo entre transiciones.

****(puede consultar el manual de usuario para conocer con más detalle su funcionamiento)****
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


Robusto:
----------------------------------------------------------------------------------------------------------------
El programa y su interfaz están bastante bien manejados e implementados, 
a modo de evitar que se rompa el programa por un mal uso.
----------------------------------------------------------------------------------------------------------------
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

Todas las máquinas de turing fueron definidas e implementadas bajo los criterios establecidos en el curso:

- Utiliza únicamente cintas semi-infinitas, si el cabezal intentara ir a la izquierda de la posición inicial
la máquina se detiene, sin validar la cadena ni el proceso.
- Si en determinado estado el cabezal lee un caracter no definido, la máquina se detiene a medio proceso
haciendo no válida la entrada.
- La entrada solo es válida, si la máquina entra en un estado de aceptación, esta automáticamente se detiene.

---------------------------------------------------------------------------
-Las máquinas de turing están definidas con algunos procesos que parecen redundantes, pues más adelante se utilizan estados con casi las mismas transiciones, esto debido a que las primeras transiciones y estados, no sólo inician con el proceso u operación, también se encarga de verificar (según los criterios anteriores) que la entrada esté un formato correcto
y no tenga símbolos no definidos en el lenguaje, o bien sena símbolos utilizados por la máquina para el proceso de una operación y altere el funcionamiento de la máquina, escribiendo esos mismos símbolos directamente en la cinta, ñuego de la verificación, la máquina puede seguir el resto de su camino tranquila, realizando los mismos procesos, utilizando símbolos de máquina, sin la preocupación de encontrarse con fallos debido a lo anteriormente mencionado.

************************************************************************************************************************
En el caso de la máquina que analiza si una cadena es palíndromo, se tuvo el cuidado de aceptar un palíndromo, así este fuera par o impar, además, a pesar de usar símbolos para remplazo de los caracteres e ir marcando los ya analizados, una vez utilizados, se van desmarcando, de modo que si la cadena es aceptada como palíndromo, al final la cinta muestra la cadena justo como estaba.
*************************************************************************************************************************
En la copia de patrones, se tomaron las mismas precauciones, pues todas las máquinas definidas en el programa usan símbolos de máquina, y se hacen verificaciones dentro de la misma definición de la máquina de no causar conflicto ingrsando estos símbolos en la cinta.
a pesar de la utilización de estos símbolos, justo como debería ser la cinta muestra la cadena duplicada justo como fue escrita.
*************************************************************************************************************************
En las que ejecutan operaciones en binario se tomaron en cuenta las siguientes consideraciones:

- se utiliza como símbolo representativo del sistema, al número "1"
- se debe ingresar valor, signo, valor, y signo de igual (ejemplo 1111*111=)
- la respuesta se mostraría de la siguiente manera: 1111*111=111111111111
- siendo que el sistema unario, repesenta números naturales, no hay forma de representar al cero, ni a los número negativos, por tanto no hay forma de ingresarlos (hacer"11+=") no va a sumar 2+0, simplemente no lo va a aceptar.
-bajo el mismo criterio, las operaciones (específicamente la resta) tampoco puede restar números que den de resultado negativo o cero, (restar dos número iguales, o restarle un número mayor a otro número), la máquina rechazaría esto: 
"11-11=" y esto "111-111111="
- los estados y transiciones toman en consideración, que no se puedan repetir signos, no puedo hacer esto:
"111--11=", ni esto: "11-1==" de es modo también sabemos que solo son 2 números por operación (es decir no se puede hacer esto 111+11+1=).

como dije antes en todas las máquinas se toman las precauciones del ingreso de símbolos de cinta, la máquina está definida para rechazarlos desde el principio (a nivel de definición y no de programación) y que no cause confución en las operaciones.

(lo hice sencillo pero si me esforcé en cumplir con todos los requerimientos)

¡ESPERO EL PROYECTO, SEA DE SU AGRADO!



