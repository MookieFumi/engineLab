## POO. Conceptos básicos ##

- **Abstracción**/ Abstraction. 
	<p>La abstracción consiste en aislar un elemento de su contexto.</p>

- **Encapsulación**/ Encapsulation.
    <p>Unir en la clase propiedades y comportamientos (métodos).</p>

- **Poliformismo**/ Polymorphism.
    <p>Capacidad que tienen los objetos de una clase de responder al mismo mensaje o evento en función de los parámetros utilizados durante su invocación.</p>

- **Herencia**/ Inheritance.
    <p>Mecanismo por medio del cual una clase se deriva de otra de manera que extiende su funcionalidad.</p>

## POO. Principios ##
- Encapsular lo que varía.
- Favorecer la composición sobre la herencia.
- Programa contra interfaces, no contra implementaciones.

## Asociación, agregación, composición. ##

<p>Son formas de representar las relaciones existentes entre clases.</p>

- **Asociación**. 
	<p>Relación entre objetos sin depender el uno del otro. Relación 1:1.</p>
- **Agregración**.
	<p>Muy similar a la asociación variando sólo la multiplicidad, relación 1:n</p>	
	![](http://yuml.me/diagram/scruffy/class/%252F%252F%20Cool%20Class%20Diagram,%20%5BGender%5D+-%3E%5BPerson%5D.png)
	<p>La Gender agrupa varios elementos del tipo Person.</p>
- **Composición**.
	<p>Relación más fuerte, el tiempo de vida de un objeto está condicionado por el tiempo de vida del objeto que lo incluye.</p>
	![](http://yuml.me/diagram/scruffy/class/%252F%252F%20Cool%20Class%20Diagram,%20%5BPerson%5D++-%3E%5BAddress%5D.png) 
	<p>La clase Person agrupa varios elementos del tipo Address.</p>
	<p>El tiempo de vida de los objetos de tipo Address está condicionado por el tiempo de vida del objeto de tipo Person.</p>
	


