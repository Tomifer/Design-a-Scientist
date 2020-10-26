<?php
    $file = fopen("",r);
    echo fread($file, filesize("DAS_Conf.txt"));
    fclose($file);
?>