<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Menú del Restaurante</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            color: #333;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
        }

        h1 {
            color: #dc3545;
            text-align: center;
            margin-bottom: 20px;
        }

        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
        }

        li {
            display: inline;
            margin-right: 20px;
        }

        a {
            text-decoration: none;
            color: #333;
            transition: color 0.3s ease;
        }

        a:hover {
            color: #dc3545;
        }

        img {
            display: block;
            margin: 0 auto;
            margin-bottom: 20px;
            border-radius: 10px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        table th, table td {
            padding: 12px;
            border: 1px solid #ddd;
            text-align: left;
        }

        table th {
            background-color: #dc3545;
            color: #fff;
        }

        form {
            margin-top: 20px;
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        input[type="text"],
        select {
            width: calc(100% - 24px);
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        input[type="submit"] {
            background-color: #dc3545;
            color: #fff;
            padding: 12px 20px;
            border: none;
            cursor: pointer;
            border-radius: 5px;
            transition: background-color 0.3s ease;
        }

        input[type="submit"]:hover {
            background-color: #c82333;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Menú del Restaurante</h1>
        <ul>
            <li><a href="Practica 6 Salvador.html">Principal</a></li>
        </ul>
        <h2>¡BIENVENIDOS!</h2>
        <p><i>Bienvenidos a nuestro restaurante. Aquí encontrarás una deliciosa variedad de platos que seguro te encantarán.</i></p>
        <img src="Yo.jpg" width="200" alt="Imagen del Chef">
        <h2>Platos</h2>
        <table>
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Precio</th>
                    <th>Descripción</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Lomo Saltado</td>
                    <td>$15</td>
                    <td>Delicioso plato peruano con carne, papas fritas, cebolla, tomate y arroz.</td>
                </tr>
                <tr>
                    <td>Pizza Margarita</td>
                    <td>$12</td>
                    <td>Pizza tradicional con salsa de tomate, mozzarella y albahaca fresca.</td>
                </tr>
                <tr>
                    <td>Sushi Variado</td>
                    <td>$18</td>
                    <td>Selección de sushi fresco con variedad de pescados, arroz y algas nori.</td>
                </tr>
            </tbody>
        </table>
        <h2>Formulario de Precios</h2>
        <form>
            <label for="nombre">Nombre del plato:</label>
            <input type="text" id="nombre" name="nombre" required>
            <label for="precio">Precio:</label>
            <input type="text" id="precio" name="precio" required>
            <label for="descripcion">Descripción:</label>
            <textarea id="descripcion" name="descripcion" required></textarea>
            <input type="submit" value="Enviar">
        </form>
    </div>
</body>
</html>