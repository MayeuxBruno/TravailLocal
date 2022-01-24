<?php
class Texte
{

	/*****************Attributs***************** */

	private $_idTexte;
	private $_codeTexte;
    private $_fr;
    private $_en;
	private static $_attributes=["idTexte","codeTexte","fr","en"];

	/***************** Accesseurs ***************** */
	
    public function getIdTexte()
	{
		return $this->_IdTexte;
	}

	public function setIdTexte($idTexte)
	{
		$this->_idTexte = $idTexte;

	}

	public function getCodeTexte()
	{
		return $this->_codeTexte;
	}

	public function setCodeTexte($codeTexte)
	{
		$this->_codeTexte = $codeTexte;
	}

    public function getFr()
	{
		return $this->_fr;
	}

	public function setFr($fr)
	{
		$this->_fr = $fr;
	}

    public function getEn()
	{
		return $this->_en;
	}

	public function setEn($en)
	{
		$this->_en = $en;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "GradeId: ".$this->getGradeId()."<br>GradeName : ".$this->getGradeName();
	}

}