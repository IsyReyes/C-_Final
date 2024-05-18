# Proyecto de Ejercicios de Programación en C#

Este proyecto es una compilación de varios ejercicios de programación, los cuales pueden ser utilizados a través de un menú de selección. Además, el programa maneja errores en la entrada numérica.

## Contenido del Proyecto

El proyecto incluye múltiples clases que contienen diferentes ejercicios y utilidades:

BasicArithmetic.cs: Operaciones aritméticas básicas.
arrays.cs: Manipulación y uso de arrays.
degreeconversion.cs: Conversión de grados.
employeehourly.cs: Cálculo de salario por hora.
errorhandler.cs: Manejo de errores en la entrada de datos.
failorpass.cs: Determinación de aprobado o reprobado.
helloworld.cs: Imprimir "Hola Mundo".
initializer.cs: Inicialización de variables.
loopcontrol.cs: Control de bucles.
matrix.cs: Ejercicios relacionados con matrices.
matrixgeneration.cs: Generación de matrices.
matrixoperations.cs: Operaciones con matrices.
matrixprinter.cs: Impresión de matrices.
options.cs: Opciones del menú.
printbinary.cs: Impresión de números en binario.
promos.cs: Manejo de promociones.
ratebytons.cs: Calcular tarifa por toneladas.
sayhi.cs: Imprimir un saludo.
sequencing.cs: Secuenciación de operaciones.
squareroot.cs: Calcular raíz cuadrada.
stairs.cs: Dibujar escaleras.
sums.cs: Sumar números.
switchmanager.cs: Manejo del menú de selección.
variableexchange.cs: Intercambio de variables.

## Instalación

Requisitos Previos

Asegúrate de tener instalado .NET SDK en tu sistema. Puedes descargarlo desde el sitio web oficial de .NET.

Instalación de ConsoleTables

Para imprimir tablas en la consola, utilizamos la biblioteca ConsoleTables. Sigue estos pasos para instalarla:

Abre la terminal en el directorio raíz de tu proyecto.

Ejecuta el comando para instalar ConsoleTables.

Compilación y Ejecución del Proyecto

Navega al directorio raíz de tu proyecto. Luego, compila y ejecuta el proyecto utilizando los comandos apropiados en la terminal.


## Uso del Programa

Al ejecutar el programa, se presentará un menú de selección que permite elegir entre varios ejercicios y utilidades. Simplemente introduce el número correspondiente a la opción que deseas ejecutar.

## Ejemplo de Menú

Selecciona una opción:

ChessBoard
MatrixBig
TestRandomMatrix
AnalyzeLargeMatrix
Generate 10x10 Matrix and Calculate Sums
Generate and Swap Columns in 10x10 Matrix
Generate 10x10 Matrix and Analyze for Specific Criteria
Salir

## Introduce tu elección:

El programa manejará la entrada del usuario y ejecutará la opción seleccionada. Si la entrada no es válida, el programa solicitará que se ingrese un valor correcto.


## Manejo de Errores

El proyecto incluye la clase ErrorHandler para manejar errores en la entrada de datos numéricos. Esta clase asegura que el usuario introduzca datos válidos antes de continuar con la ejecución del programa.


## Métodos de ErrorHandler

SafeParseInt(string prompt): Solicita al usuario un número entero, manejando errores de entrada.
SafeParseDouble(string prompt): Solicita al usuario un número decimal, manejando errores de entrada.
RequiredString(string prompt): Solicita al usuario una cadena de texto no vacía.