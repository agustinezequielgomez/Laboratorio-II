using Entidades;
using System;
public delegate void actualizarNombrePorDelegado(string message);
public delegate void actualizarFotoPorDelegado(string path);
public delegate void actualizarAlumno(Alumno alum, EventArgs evento);