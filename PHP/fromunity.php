<?php
	$avatar_gender = $_POST["avatar_gender"];
	$avatar_hair = $_POST["avatar_hair"];
	$avatar_hair_color = $_POST["avatar_hair_color"];
	$avatar_eyes = $_POST["avatar_eyes"];
	$avatar_eyes_color = $_POST["avatar_eyes_color"];
	$avatar_mouth = $_POST["avatar_mouth"];
	$avatar_skinColor = $_POST["avatar_skinColor"];
	$avatar_shirt = $_POST["avatar_shirt"];
	$avatar_shirt_color = $_POST["avatar_shirt_color"];
	$avatar_pant = $_POST["avatar_pant"];
	$avatar_pant_color = $_POST["avatar_pant_color"];
	$avatar_shoe = $_POST["avatar_shoe"];
	$avatar_shoe_color = $_POST["avatar_shoe_color"];
	$avatar_tucked = $_POST["avatar_tucked"];
	$avatar_glasses = $_POST["avatar_glasses"];
	$avatar_name = $_POST["avatar_name"];
	$avatar_description = $_POST["avatar_description"];

	$par_gender = $_POST["par_gender"];
	$par_hair = $_POST["par_hair"];
	$par_hair_color = $_POST["par_hair_color"];
	$par_eyes = $_POST["par_eyes"];
	$par_eyes_color = $_POST["par_eyes_color"];
	$par_mouth = $_POST["par_mouth"];
	$par_skinColor = $_POST["par_skinColor"];
	$par_shirt = $_POST["par_shirt"];
	$par_shirt_color = $_POST["par_shirt_color"];
	$par_pant = $_POST["par_pant"];
	$par_pant_color = $_POST["par_pant_color"];
	$par_shoe = $_POST["par_shoe"];
	$par_shoe_color = $_POST["par_shoe_color"];
	$par_tucked = $_POST["par_tucked"];
	$par_glasses = $_POST["par_glasses"];
	$par_id = $_POST["par_id"];
	$par_name = $_POST["par_name"];
	$par_description = $_POST["par_description"];
	
	$tutorial = $_POST["tutorial"];
	$making_par = $_POST["making_par"];
	$extra_info = $_POST["extra_info"];
	$date = $_POST["date"];


	if ($avatar_gender != "")
	{
		echo("Data recieved");
		echo("Field 1:" . $avatar_gender);
		echo("Field 2:" . $avatar_hair);
		echo("Field 3:" . $avatar_hair_color);
		echo("Field 4:" . $avatar_eyes);
		echo("Field 5:" . $avatar_eyes_color);
		echo("Field 6:" . $avatar_mouth);
		echo("Field 7:" . $avatar_skinColor);
		echo("Field 8:" . $avatar_shirt);
		echo("Field 9:" . $avatar_shirt_color);
		echo("Field 10:" . $avatar_pant);
		echo("Field 11:" . $avatar_pant_color);
		echo("Field 12:" . $avatar_shoe);
		echo("Field 13:" . $avatar_shoe_color);
		echo("Field 14:" . $avatar_tucked);
		echo("Field 15:" . $avatar_glasses);
		echo("Field 16:" . $avatar_name);
		echo("Field 17:" . $avatar_description);

		echo("Field 18:" . $par_gender);
		echo("Field 19:" . $par_hair);
		echo("Field 20:" . $par_hair_color);
		echo("Field 21:" . $par_eyes);
		echo("Field 22:" . $par_eyes_color);
		echo("Field 23:" . $par_mouth);
		echo("Field 24:" . $par_skinColor);
		echo("Field 25:" . $par_shirt);
		echo("Field 26:" . $par_shirt_color);
		echo("Field 27:" . $par_pant);
		echo("Field 28:" . $par_pant_color);
		echo("Field 29:" . $par_shoe);
		echo("Field 30:" . $par_shoe_color);
		echo("Field 31:" . $par_tucked);
		echo("Field 32:" . $par_glasses);
		echo("Field 33:" . $par_id);
		echo("Field 34:" . $par_name);
		echo("Field 35:" . $par_description);

		echo("Field 36:" . $tutorial);
		echo("Field 37:" . $making_par);
		echo("Field 38:" . $extra_info);
		echo("Field 39:" . $date);
		
		$file = fopen("data.csv", "a");
		fwrite($file, "\n" . $avatar_gender . ",");
		fwrite($file, $avatar_hair . ",");
		fwrite($file, $avatar_hair_color . ",");
		fwrite($file, $avatar_eyes . ",");
		fwrite($file, $avatar_eyes_color . ",");
		fwrite($file, $avatar_mouth . ",");
		fwrite($file, $avatar_skinColor . ",");
		fwrite($file, $avatar_shirt . ",");
		fwrite($file, $avatar_shirt_color . ",");
		fwrite($file, $avatar_pant . ",");
		fwrite($file, $avatar_pant_color . ",");
		fwrite($file, $avatar_shoe . ",");
		fwrite($file, $avatar_shoe_color . ",");
		fwrite($file, $avatar_tucked . ",");
		fwrite($file, $avatar_glasses . ",");
		fwrite($file, $avatar_name . ",");
		fwrite($file, $avatar_description . ",");

		fwrite($file, $par_gender . ",");
		fwrite($file, $par_hair . ",");
		fwrite($file, $par_hair_color . ",");
		fwrite($file, $par_eyes . ",");
		fwrite($file, $par_eyes_color . ",");
		fwrite($file, $par_mouth . ",");
		fwrite($file, $par_skinColor . ",");
		fwrite($file, $par_shirt . ",");
		fwrite($file, $par_shirt_color . ",");
		fwrite($file, $par_pant . ",");
		fwrite($file, $par_pant_color . ",");
		fwrite($file, $par_shoe . ",");
		fwrite($file, $par_shoe_color . ",");
		fwrite($file, $par_tucked . ",");
		fwrite($file, $par_glasses . ",");
		fwrite($file, $par_id . ",");
		fwrite($file, $par_name . ",");
		fwrite($file, $par_description . ",");

		fwrite($file, $tutorial . ",");
		fwrite($file, $making_par . ",");
		fwrite($file, $extra_info . ",");
		fwrite($file, $date);
		fclose($file);
	} else 
	{
		echo("Data sending failed");
	}
?>