package cr.ac.ucr.ie.app.controllers.pages;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
 
	@RequestMapping("/mensaje")
	public String mensaje() 
	{
		return "mensaje";
	}
}