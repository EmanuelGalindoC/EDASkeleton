# EDASkeleton

## Ejecución

1. Compila y ejecuta la aplicación:

    dotnet run
2. Prueba el endpoint con un POST a http://localhost:5069/order con el siguiente JSON ejemplo:

{
  "product": "Laptop"
}

3. Salida esperada en la consola:

    #####  [Evento Recibido] Orden Creada - ID: 123e4567-e89b-12d3-a456-426614174000, Producto: Laptop
