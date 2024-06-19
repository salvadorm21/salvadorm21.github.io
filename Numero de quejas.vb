<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Quejas</title>
    <link rel="stylesheet" href="Tema Quejas.css">
</head>
<body>
    <h1>Quejas</h1>
    <ul>
        <li><a href="Practica 6 Salvador.html">Principal</a></li>
    </ul>
    <h2>Presentación</h2>
    <p>Hola, mi nombre es <strong>Salvador Mendez Zamora</strong>. En que te podemos ayudar.</p>

    <h2>Tablas</h2>
    <table border="1">
        <tr>
            <td>Número de Contacto</td>
        </tr>
        <tr>
            <td>7971151286</td>
        </tr>
    </table>

    <h2>Formulario de Quejas</h2>
    <form action="procesar_queja.php" method="post">
        <label for="nombre">Nombre:</label><br>
        <input type="text" id="nombre" name="nombre" required><br>
        <label for="email">Correo electrónico:</label><br>
        <input type="email" id="email" name="email" required><br>
        <label for="queja">Descripción de la queja:</label><br>
        <textarea id="queja" name="queja" rows="4" required></textarea><br>
        <input type="submit" value="Enviar Queja">
    </form>
</body> 
</html>