# Soluciones Algorítmicas en C#

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![C#](https://img.shields.io/badge/Language-C%23-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/Platform-.NET-purple.svg)](https://dotnet.microsoft.com/)

Este repositorio contiene soluciones implementadas en C# para dos problemas algorítmicos: unión de intervalos traslapados y verificación de anagramas.

## 📝 Contenido

- [Problemas Resueltos](#problemas-resueltos)
  - [1. Unión de Intervalos Traslapados](#1-unión-de-intervalos-traslapados)
  - [2. Verificación de Anagramas](#2-verificación-de-anagramas)
- [Estructura del Repositorio](#estructura-del-repositorio)
- [Requisitos](#requisitos)
- [Ejecución](#ejecución)
- [Complejidad Algorítmica](#complejidad-algorítmica)
- [Contribución](#contribución)
- [Licencia](#licencia)

## Problemas Resueltos

### 1. Unión de Intervalos Traslapados

**Descripción del problema:**  
Dado un arreglo de pares (arreglo de arreglos) que representan intervalos, implementar una función que una los intervalos traslapados.

**Ejemplos:**
- `{1,3},{6,8},{9,10},{2,4}` resulta en `{1,4},{6,8},{9,10}`
- `{{6,8},{1,9},{2,4}}` resulta en `{1,9}`

**Enfoque de solución:**  
El algoritmo ordena los intervalos por su punto de inicio y luego recorre la lista, fusionando intervalos adyacentes si se solapan.

### 2. Verificación de Anagramas

**Descripción del problema:**  
Implementar una función que recibe dos strings y determina si son anagramas o no. Dos palabras son anagramas si contienen los mismos caracteres pero en diferente orden.

**Ejemplos:**
- "listen" y "silent" son anagramas
- "hello" y "world" no son anagramas

**Enfoques de solución:**
1. **Método de conteo de caracteres:** Usa diccionarios para contar la frecuencia de cada carácter
2. **Método de ordenamiento:** Ordena los caracteres de ambas cadenas y compara los resultados

## Estructura del Repositorio

```
├── src/
│   ├── UnirIntervalos.cs        # Solución al problema de intervalos
│   └── SonAnagramas.cs          # Solución al problema de anagramas
├── tests/                       # Pruebas unitarias
├── .gitignore
├── LICENSE
└── README.md
```

## Requisitos

- .NET 6.0 o superior
- Cualquier IDE compatible con C# (Visual Studio, VS Code con extensiones adecuadas, Rider, etc.)

## Ejecución

### Compilación

```bash
# Navegar al directorio del proyecto
cd src

# Compilar
dotnet build
```

### Ejecución

```bash
# Ejecutar el programa de intervalos
dotnet run --project UnirIntervalos.cs

# Ejecutar el programa de anagramas
dotnet run --project SonAnagramas.cs
```

## Uso Interactivo

Ambas aplicaciones son interactivas y guiarán al usuario durante su ejecución:

1. **Unión de Intervalos:**
   - Solicitará el número de intervalos a ingresar
   - Para cada intervalo, pedirá el inicio y fin en formato "inicio,fin"
   - Mostrará los intervalos originales y el resultado después de unirlos

2. **Verificación de Anagramas:**
   - Solicitará dos palabras o frases
   - Verificará si son anagramas usando dos métodos diferentes
   - Permitirá repetir la operación con nuevas palabras

## Complejidad Algorítmica

### Unión de Intervalos
- **Tiempo:** O(n log n) debido al ordenamiento inicial
- **Espacio:** O(n) para almacenar el resultado

### Verificación de Anagramas
1. **Método de conteo:**
   - **Tiempo:** O(n)
   - **Espacio:** O(k) donde k es el tamaño del alfabeto

2. **Método de ordenamiento:**
   - **Tiempo:** O(n log n)
   - **Espacio:** O(n)

## Contribución

Si deseas contribuir a este repositorio, puedes:
1. Fork del repositorio
2. Crear una rama para tu feature (`git checkout -b feature/NuevaCaracteristica`)
3. Commit de tus cambios (`git commit -m 'Añadir nueva característica'`)
4. Push a la rama (`git push origin feature/NuevaCaracteristica`)
5. Abrir un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE.txt) para más detalles.
