<?php
    $file = fopen("DAS_Conf.txt", "r");
    echo fread($file, filesize("DAS_Conf.txt"));
    fclose($file);
?>