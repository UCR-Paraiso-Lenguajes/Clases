package cr.ac.ucr.ie.app.controllers.pages;

import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;

import cr.ac.ucr.ie.app.domain.Departamento;

@Controller
public class HomeController 
{
 
	private Departamento dep = new Departamento(1, "Lenguajes");
	@RequestMapping("/")
	public String mensaje(ModelMap model) 
	{
		model.addAttribute("empleados", dep.listarEmpleados());
		
		return "empleados";
	}
}