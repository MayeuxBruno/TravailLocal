<body class="colonne">
    <header class="colonne">
        <div class="espace"></div>
        <div>
        <div class="demi"></div>
        <div class="demi"><img src="IMG/logo.png" alt="logo"></div>
        <div class="titre center double colonne">
            <div><h1>LogiCamp</h1></div>
            <div classe="espace"></div>
            <div><?php echo $titre; ?></div>
        </div>
        <div class="colonne demi">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . " ". $_SESSION['utilisateur']->getPrenom() .'</div>';
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center">'. texte("Deconnection") .'</a></div>';
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
            }
            ?>

        </div>
        <div class="demi"></div>
        </div>
        <div class="espace"></div>
    </header>