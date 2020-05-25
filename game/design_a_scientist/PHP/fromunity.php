<?php
	$textHair = $_POST["hair"];
	$textHairColor = $_POST["hair_color"];
	$textEyes = $_POST["eyes"];
	$textEyeColor = $_POST["eyes_color"];
	$textMouth = $_POST["mouth"];
	$textHeadEffect = $_POST["headEffect"];
	$textSkinColor = $_POST["skinColor"];
	$textDate = $_POST["date"];
	
	if ($textHair != "")
	{
		echo("Data recieved");
		echo("Field 1:" . $textHair);
		echo("Field 2:" . $textHairColor);
		echo("Field 3:" . $textEyes);
		echo("Field 4:" . $textEyeColor);
		echo("Field 5:" . $textMouth);
		echo("Field 6:" . $textHeadEffect);
		echo("Field 7:" . $textSkinColor);
		echo("Field 8:" . $textDate);
		$file = fopen("data.csv", "a");
		fwrite($file, "\n" . $textHair . ",");
		fwrite($file, $textHairColor . ",");
		fwrite($file, $textEyes . ",");
		fwrite($file, $textEyeColor . ",");
		fwrite($file, $textMouth . ",");
		fwrite($file, $textHeadEffect . ",");
		fwrite($file, $textSkinColor . ",");
		fwrite($file, $textDate);
		fclose($file);
	} else 
	{
		echo("Data sending failed");
	}
?>