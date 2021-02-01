<!DOCTYPE html>
<html>

<head>
        <title>Design-a-Scientist Download Page</title>
</head>

<body>

        <h1 style="text-align:center;"> This is the download link for either the recorded data CSV file or the user manual </h1>
        <font size="60">
                <a href="/PHP/data.csv" download="data.csv">
                        <p style="text-align:center;"> Download Data Link </p>
                </a>
                <a href="/PHP/Design-A-Scientist_Administrator_Manual_1_31_2021.pdf" download="Design-A-Scientist_Administrator_Manual_1_31_2021.pdf">
                        <p style="text-align:center;"> Download PDF Manual Link </p>
                </a>
        </font>

        <p>
                These check boxes are used to configure the Design-A-Scientist software. Click the boxes if you would like the
                feature to
                be active
        </p>

        <form method="post">

        <input type="checkbox" id="tutorial" name="tutorial" value="tutorial">
        <label for="tutorial" name="tutorial"> Check this box if you would like there to be a tutorial</label><br>
        <input type="checkbox" id="avatar" name="avatar" value="avatar">
        <label for="avatar" name="avatar"> Check this box if you would like the children to create a personal avatar</label><br>
        <button name="button">Click to update configuration</button>
        <?php
        if (isset($_POST['button'])) {
                $file = fopen("PHP/DAS_Conf.txt", "w");
                if (isset($_POST['tutorial'])) {
                        $info = "1,";
                        fwrite($file, $info);
                } else {
                        $info = "0,";
                        fwrite($file, $info);
                }

                if (isset($_POST['avatar'])) {
                        $info = "1,0";
                        fwrite($file, $info);
                } else {
                        $info = "0,0";
                        fwrite($file, $info);
                }

                fclose($file);
        }
        ?>

        </form>
</body>

</html>