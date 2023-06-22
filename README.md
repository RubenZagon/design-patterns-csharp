# Patrones de diseño

## Patrones de creación

### Abstract Factory

Proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.


### Builder

Separa la construcción de un objeto complejo de su representación, de modo que el mismo proceso de construcción pueda crear diferentes representaciones.

### Factory Method

Define una interfaz para crear un objeto, pero deja que las subclases decidan qué clase instanciar. Permite que una clase delegue la creación de instancias a subclases.

### Prototype

Especifica los tipos de objetos a crear mediante una instancia prototípica y crea nuevos objetos copiando este prototipo.

### Singleton

Asegura que una clase tenga una única instancia y proporciona un punto de acceso global a ella.

## Patrones estructurales

### Adapter

Convierte la interfaz de una clase en otra interfaz que los clientes esperan. Permite que clases con interfaces incompatibles trabajen juntas.

### Bridge

Desacopla una abstracción de su implementación, de modo que ambas puedan variar independientemente.

### Composite

Compone objetos en estructuras de árbol para representar jerarquías de parte-todo. Permite a los clientes tratar de manera uniforme objetos individuales y composiciones de objetos.

### Decorator

Adjunta dinámicamente responsabilidades adicionales a un objeto. Proporciona una alternativa flexible a la herencia para extender la funcionalidad.

### Facade

Proporciona una interfaz unificada para un conjunto de interfaces en un subsistema. Define una interfaz de nivel superior que hace que el subsistema sea más fácil de usar.

### Flyweight

Utiliza el uso compartido para admitir eficientemente grandes cantidades de objetos de granularidad fina.

### Proxy

Proporciona un representante o sustituto de otro objeto para controlar el acceso a él.

## Patrones de comportamiento

### Chain of Responsibility

Evita acoplar el remitente de una solicitud a su receptor al dar a más de un objeto la oportunidad de manejar la solicitud. Encadena los objetos receptores y pasa la solicitud a lo largo de la cadena hasta que un objeto la maneja.

### Command

Encapsula una solicitud como un objeto, lo que le permite parametrizar clientes con diferentes solicitudes, encolar o registrar solicitudes y admitir operaciones que se pueden deshacer.

### Interpreter

Da una representación de su gramática junto con un intérprete que usa la representación para interpretar oraciones en el lenguaje.

### Iterator

Proporciona una forma de acceder secuencialmente a los elementos de un objeto agregado sin exponer su representación subyacente.

### Mediator

Define un objeto que encapsula cómo interactúan un conjunto de objetos. Promueve el acoplamiento débil al evitar que los objetos se refieran entre sí explícitamente y permite variar sus interacciones independientemente.

### Memento

Sin violar el principio de encapsulamiento, captura y externaliza un estado interno de un objeto, de modo que el objeto pueda restaurarse a este estado más tarde.

### Observer

Define una dependencia uno a muchos entre objetos para que cuando un objeto cambie de estado, todos sus dependientes sean notificados y actualizados automáticamente.

### State

Permite que un objeto altere su comportamiento cuando su estado interno cambia. Parece como si el objeto cambiara su clase.

### Strategy

Define una familia de algoritmos, encapsula cada uno y los hace intercambiables. Permite que el algoritmo varíe independientemente de los clientes que lo utilizan.

### Template Method

Define el esqueleto de un algoritmo en una operación, delegando algunos pasos a las subclases. Permite que las subclases redefinan ciertos pasos de un algoritmo sin cambiar la estructura del propio algoritmo.

### Visitor ✅

Representa una operación a realizar en los elementos de una estructura de objetos. Permite definir una nueva operación sin cambiar las clases de los elementos sobre los que opera.

