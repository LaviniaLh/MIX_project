using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chemistry_Controller : MonoBehaviour {

	[SerializeField]
	private GameObject startButton;
	[SerializeField]
	private GameObject menuButton;
	[SerializeField]
	private GameObject buttons;
	[SerializeField]
	private GameObject informationPanel;
	[SerializeField]
	private Text textInformation;
	[SerializeField]
	private GameObject closePanel;

	// Use this for initialization
	void Start () {
		startButton.SetActive(true);
		buttons.SetActive(false);
		informationPanel.SetActive(false);
		menuButton.SetActive(false);
	}	
	
	// Update is called once per frame
	void Update () {
	}

    public void onStartButton() {
      startButton.SetActive(false);
			buttons.SetActive(true);
			menuButton.SetActive(true);
    }

	public void onElementClicked (Button element) {
		if (element.name == "H") {
				textInformation.text = "Hydrogen is a chemical element with symbol H and atomic number 1. With a standard atomic weight of 1.008, hydrogen is the lightest element in the periodic table. Hydrogen is the most abundant chemical substance in the Universe, constituting roughly 75% of all baryonic mass.";
		} else if (element.name == "Li") {
				textInformation.text = "Lithium (from Greek: λίθος, romanized: lithos, lit. 'stone') is a chemical element with symbol Li and atomic number 3. It is a soft, silvery-white alkali metal. Under standard conditions, it is the lightest metal and the lightest solid element. ";
		} else if (element.name == "Na") {
				textInformation.text = "Sodium is a chemical element with symbol Na (from Latin natrium) and atomic number 11. It is a soft, silvery-white, highly reactive metal. Sodium is an alkali metal, being in group 1 of the periodic table, because it has a single electron in its outer shell.";
		} else if (element.name == "K") {
				textInformation.text = "Potassium is a chemical element with symbol K (from Neo-Latin kalium) and atomic number 19. Potassium is a silvery-white metal that is soft enough to be cut with a knife, with little force. Potassium in nature occurs only in ionic salts.";
		} else if (element.name == "Rb") {
				textInformation.text = "Rubidium is a chemical element with symbol Rb and atomic number 37. Rubidium is a very soft, silvery-white metal in the alkali metal group. Rubidium metal shares similarities to potassium metal and cesium metal in physical appearance, softness and conductivity.";
		} else if (element.name == "Cs") {
				textInformation.text = "Caesium is a chemical element with symbol Cs and atomic number 55. It is a soft, silvery-golden alkali metal with a melting point of 28.5 °C (83.3 °F), which makes it one of only five elemental metals that are liquid at or near room temperature.";
		} else if (element.name == "Fr") {
				textInformation.text = "Francium is a chemical element with symbol Fr and atomic number 87. It is extremely radioactive; its most stable isotope, francium-223 has a half-life of only 22 minutes. Francium was discovered by Marguerite Perey in France in 1939.";
		} else if (element.name == "Be") {
				textInformation.text = "Beryllium is a chemical element with symbol Be and atomic number 4. It is a relatively rare element in the universe, usually occurring as a product of the spallation of larger atomic nuclei that have collided with cosmic rays.";
		} else if (element.name == "Mg") {
				textInformation.text = "Magnesium is a chemical element with symbol Mg and atomic number 12. It is a shiny gray solid, the ninth most abundant element in the universe.  It is produced in large, aging stars from the sequential addition of three helium nuclei to a carbon nucleus.";
		} else if (element.name == "Ca") {
				textInformation.text = "Calcium is a chemical element with symbol Ca and atomic number 20. It is the fifth most abundant element in Earth's crust and the third most abundant metal, after iron and aluminium. The name derives from Latin calx 'lime', which was obtained from heating limestone.";
		} else if (element.name == "Sr") {
				textInformation.text = "Strontium is the chemical element with symbol Sr and atomic number 38. An alkaline earth metal, strontium is a soft silver-white yellowish metallic element that is highly chemically reactive. The metal forms a dark oxide layer when it is exposed to air.";
		} else if (element.name == "Ba") {
				textInformation.text = "Barium is a chemical element with symbol Ba and atomic number 56. It is the fifth element in group 2 and is a soft, silvery alkaline earth metal. Barium was identified as a new element in 1774, but not reduced to a metal until 1808 with the advent of electrolysis.";
		} else if (element.name == "Ra") {
				textInformation.text = "Radium is a chemical element with symbol Ra and atomic number 88. It is the sixth element in group 2 of the periodic table, also known as the alkaline earth metals. It readily reacts with nitrogen on exposure to air, forming a black surface layer of radium nitride (Ra3N2).";
		} else if (element.name == "Sc") {
				textInformation.text = "Scandium is a chemical element with symbol Sc and atomic number 21. A silvery-white metallic d-block element, it has historically been classified as a rare-earth element. It was discovered in 1879 by spectral analysis of the minerals euxenite and gadolinite from Scandinavia.";
		} else if (element.name == "Y") {
				textInformation.text = "Yttrium is a chemical element with symbol Y and atomic number 39. It is a silvery-metallic transition metal chemically similar to the lanthanides and has often been classified as a 'rare-earth element'. Y is the only isotope found in the Earth's crust.";
		} else if (element.name == "La") {
				textInformation.text = "Lanthanum is a chemical element with symbol La and atomic number 57. It is a soft, ductile, silvery-white metal that tarnishes rapidly when exposed to air and is soft enough to be cut with a knife. It is traditionally counted among the rare earth elements.";
		} else if (element.name == "Ac") {
				textInformation.text = "Actinium is a chemical element with symbol Ac and atomic number 89. It was first isolated by French chemist André-Louis Debierne in 1899. Friedrich Oskar Giesel later independently isolated it in 1902 and, unaware that it was already known, gave it the name emanium.";
		} else if (element.name == "Ti") {
				textInformation.text = "Titanium is a chemical element with symbol Ti and atomic number 22. It is a lustrous transition metal with a silver color, low density, and high strength. Titanium is resistant to corrosion in sea water, aqua regia, and chlorine.";
		} else if (element.name == "Zr") {
				textInformation.text = "Zirconium is a chemical element with symbol Zr and atomic number 40. The name zirconium is taken from the name of the mineral zircon (the word is related to Persian zargun (zircon;zar-gun, 'gold-like' or 'as gold')), the most important source of zirconium.";
		} else if (element.name == "Hf") {
				textInformation.text = "Hafnium is a chemical element with symbol Hf and atomic number 72. A lustrous, silvery gray, tetravalent transition metal, hafnium chemically resembles zirconium and is found in many zirconium minerals. Hafnium is used in filaments and electrodes.";
		} else if (element.name == "Rf") {
				textInformation.text = "Rutherfordium is a synthetic chemical element with symbol Rf and atomic number 104, named after physicist Ernest Rutherford. As a synthetic element, it is not found in nature and can only be created in a laboratory.";
		} else if (element.name == "V") {
				textInformation.text = "Vanadium is a chemical element with symbol V and atomic number 23. It is a hard, silvery-grey, ductile, malleable transition metal. Vanadium occurs naturally in about 65 minerals and in fossil fuel deposits.";
		} else if (element.name == "Nb") {
				textInformation.text = "Niobium, formerly known as columbium, is a chemical element with symbol Nb (formerly Cb) and atomic number 41. Niobium is a strong, light grey, crystalline, and ductile transition metal. Niobium is often found in the minerals pyrochlore and columbite.";
		} else if (element.name == "Ta") {
				textInformation.text = "Tantalum is a chemical element with symbol Ta and atomic number 73. Previously known as tantalium, its name comes from Tantalus, a villain from Greek mythology. Tantalum is a rare, hard, blue-gray, lustrous transition metal that is highly corrosion-resistant.";
		} else if (element.name == "Db") {
				textInformation.text = "Dubnium is a synthetic chemical element with symbol Db and atomic number 105. Dubnium is highly radioactive: the most stable known isotope, dubnium-268, has a half-life of about 28 hours. This greatly limits the extent of research on dubnium.";
		} else if (element.name == "Cr") {
				textInformation.text = "Chromium is a chemical element with symbol Cr and atomic number 24. It is the first element in group 6. It is a steely-grey, lustrous, hard and brittle transition metal. It is also the main additive in stainless steel, to which it adds anti-corrosive properties.";
		} else if (element.name == "Mo") {
				textInformation.text = "Molybdenum is a chemical element with symbol Mo and atomic number 42. The name is from Neo-Latin molybdaenum, from Ancient Greek Μόλυβδος molybdos, meaning lead, since its ores were confused with lead ores.";
		} else if (element.name == "W") {
				textInformation.text = "Tungsten, or wolfram, is a chemical element with symbol W and atomic number 74. Tungsten is a rare metal found naturally on Earth almost exclusively combined with other elements in chemical compounds rather than alone.";
		} else if (element.name == "Sg") {
				textInformation.text = "Seaborgium is a synthetic chemical element with symbol Sg and atomic number 106. As a synthetic element, it can be created in a laboratory but is not found in nature. It is also radioactive; the most stable known isotope, 269Sg, has a half-life of approximately 14 minutes.";
		} else if (element.name == "Mn") {
				textInformation.text = "Manganese is a chemical element with symbol Mn and atomic number 25. It is not found as a free element in nature; it is often found in minerals in combination with iron. Manganese is a transition metal with important industrial alloy uses, particularly in stainless steels.";
		} else if (element.name == "Tc") {
				textInformation.text = "Technetium is a chemical element with symbol Tc and atomic number 43. It is the lightest element whose isotopes are all radioactive; none are stable, excluding the fully ionized state of 97Tc. The most common naturally occurring isotope is 99Tc.";
		} else if (element.name == "Re") {
				textInformation.text = "Rhenium is a chemical element with symbol Re and atomic number 75. It is a silvery-gray, heavy, third-row transition metal in group 7 of the periodic table. With an estimated average concentration of 1 part per billion, it is one of the rarest elements in the Earth's crust.";
		} else if (element.name == "Bh") {
				textInformation.text = "Bohrium is a synthetic chemical element with symbol Bh and atomic number 107. It is named after Danish physicist Niels Bohr. As a synthetic element, it can be created in a laboratory but is not found in nature. It is radioactive.";
		} else if (element.name == "Fe") {
				textInformation.text = "Iron is a chemical element with symbol Fe and atomic number 26. It is a metal, that belongs to the first transition series and group 8 of the periodic table. It is by mass the most common element on Earth and the fourth most common element in the Earth's crust.";
		} else if (element.name == "Ru") {
				textInformation.text = "Ruthenium is a chemical element with symbol Ru and atomic number 44. It is a rare transition metal belonging to the platinum group of the periodic table. Like the other metals of the platinum group, ruthenium is inert to most other chemicals.";
		} else if (element.name == "Os") {
				textInformation.text = "Osmium is a chemical element with symbol Os and atomic number 76. It is a hard, brittle, bluish-white transition metal in the platinum group that is found as a trace element in alloys, mostly in platinum ores.";
		} else if (element.name == "Hs") {
				textInformation.text = "Hassium is a synthetic chemical element with symbol Hs and atomic number 108. It is named after the German state of Hesse. It is a synthetic element and radioactive; the most stable known isotope, 270Hs, has a half-life of approximately 10 seconds.";
		} else if (element.name == "Co") {
				textInformation.text = "Cobalt is a chemical element with symbol Co and atomic number 27. Like nickel, cobalt is found in the Earth's crust only in chemically combined form, save for small deposits found in alloys of natural meteoric iron.";
		} else if (element.name == "Rh") {
				textInformation.text = "Rhodium is a chemical element with symbol Rh and atomic number 45. It is a rare, silvery-white, hard, corrosion-resistant, and chemically inert transition metal. It is a noble metal and a member of the platinum group. It has only one naturally occurring isotope, 103Rh.";
		} else if (element.name == "Ir") {
				textInformation.text = "Iridium is a chemical element with symbol Ir and atomic number 77. A very hard, brittle, silvery-white transition metal of the platinum group, iridium is the second-densest metal (after osmium) with a density of 22.56 g/cm3 as defined by experimental X-ray crystallography.";
		} else if (element.name == "Mt") {
				textInformation.text = "Meitnerium is a synthetic chemical element with symbol Mt and atomic number 109. It is an extremely radioactive synthetic element. The most stable known isotope, meitnerium-278, has a half-life of 7.6 seconds.";
		} else if (element.name == "Ni") {
				textInformation.text = "Nickel is a chemical element with symbol Ni and atomic number 28. It is a silvery-white lustrous metal with a slight golden tinge. It belongs to the transition metals and is hard and ductile. It is one of four elements that are ferromagnetic at approximately room temperature.";
		} else if (element.name == "Pd") {
				textInformation.text = "Palladium is a chemical element with symbol Pd and atomic number 46. It is a rare and lustrous silvery-white metal discovered in 1803 by William Hyde Wollaston. Palladium is a key component of fuel cells.";
		} else if (element.name == "Pt") {
				textInformation.text = "Platinum is a chemical element with symbol Pt and atomic number 78. It is a dense, malleable, ductile, highly unreactive, precious, silverish-white transition metal. Its name is derived from the Spanish term platino, meaning 'little silver'.";
		} else if (element.name == "Ds") {
				textInformation.text = "Darmstadtium is a synthetic chemical element with symbol Ds and atomic number 110. It is an extremely radioactive synthetic element. The most stable known isotope, darmstadtium-281, has a half-life of approximately 12.7 seconds.";
		} else if (element.name == "Cu") {
				textInformation.text = "Copper is a chemical element with symbol Cu and atomic number 29. It is a soft, malleable, and ductile metal with very high thermal and electrical conductivity. A freshly exposed surface of pure copper has a pinkish-orange color.";
		} else if (element.name == "Ag") {
				textInformation.text = "Silver is a chemical element with symbol Ag and atomic number 47. A soft, lustrous transition metal, it exhibits the highest electrical conductivity, thermal conductivity, and reflectivity of any metal. Most silver is produced as a byproduct of copper, gold, lead, and zinc refining.";
		} else if (element.name == "Au") {
				textInformation.text = "Gold is a chemical element with symbol Au (from Latin: aurum) and atomic number 79, making it one of the higher atomic number elements that occur naturally. In its purest form, it is a bright, slightly reddish yellow, dense, soft, malleable, and ductile metal.";
		} else if (element.name == "Rg") {
				textInformation.text = "Roentgenium is a chemical element with symbol Rg and atomic number 111. It is an extremely radioactive synthetic element that can be created in a laboratory but is not found in nature. In the periodic table, it is a d-block transactinide element.";
		} else if (element.name == "Zn") {
				textInformation.text = "Zinc is a chemical element with the symbol Zn and atomic number 30. Zinc is a slightly brittle metal at room temperature and has a blue-silvery appearance when oxidation is removed. It is the first element in group 12 of the periodic table.";
		} else if (element.name == "Cd") {
				textInformation.text = "Cadmium is a chemical element with symbol Cd and atomic number 48. This soft, silvery-white metal is chemically similar to the two other stable metals in group 12, zinc and mercury. It was discovered in 1817 simultaneously by Stromeyer and Hermann.";
		} else if (element.name == "Hg") {
				textInformation.text = "Mercury is a chemical element with symbol Hg and atomic number 80. A heavy, silvery d-block element, it is the only metallic element that is liquid at standard conditions for temperature and pressure; the only other element that is liquid under these conditions is the halogen bromine.";
		} else if (element.name == "Cn") {
				textInformation.text = "Copernicium is a synthetic chemical element with symbol Cn and atomic number 112. Its known isotopes are extremely radioactive, and have only been created in a laboratory. The most stable known isotope, copernicium-285, has a half-life of approximately 29 seconds.";
		} else if (element.name == "B") {
				textInformation.text = "Boron is a chemical element with symbol B and atomic number 5. Produced entirely by cosmic ray spallation and supernovae and not by stellar nucleosynthesis, it is a low-abundance element in the Solar system and in the Earth's crust.";
		} else if (element.name == "C") {
				textInformation.text = "Carbon is a chemical element with symbol C and atomic number 6. It is nonmetallic and tetravalent—making four electrons available to form covalent chemical bonds. It belongs to group 14 of the periodic table.";
		} else if (element.name == "N") {
				textInformation.text = "Nitrogen is a chemical element with symbol N and atomic number 7. It was first discovered and isolated by Scottish physician Daniel Rutherford in 1772. Nitrogen is the lightest member of group 15 of the periodic table, often called the pnictogens.";
		} else if (element.name == "O") {
				textInformation.text = "Oxygen is the chemical element with the symbol O and atomic number 8. It is a member of the chalcogen group on the periodic table, a highly reactive nonmetal, and an oxidizing agent that readily forms oxides with most elements as well as with other compounds.";
		} else if (element.name == "F") {
				textInformation.text = "Fluorine is a chemical element with symbol F and atomic number 9. It is the lightest halogen and exists as a highly toxic pale yellow diatomic gas at standard conditions. Among the elements, fluorine ranks 24th in universal abundance and 13th in terrestrial abundance.";
		} else if (element.name == "Ne") {
				textInformation.text = "Neon is a chemical element with symbol Ne and atomic number 10. It is a noble gas, a colorless, odorless, inert monatomic gas under standard conditions, with about two-thirds the density of air. It was discovered (along with krypton and xenon) in 1898.";
		} else if (element.name == "He") {
				textInformation.text = "Helium is a chemical element with symbol He and atomic number 2. It is a colorless, odorless, tasteless, non-toxic, inert, monatomic gas, the first in the noble gas group in the periodic table. After hydrogen, helium is the second lightest and second most abundant element in the  universe.";
		} else if (element.name == "Al") {
				textInformation.text = "Aluminium is a chemical element with symbol Al and atomic number 13. It is a silvery-white, soft, nonmagnetic and ductile metal in the boron group. By mass, aluminium makes up about 8% of the Earth's crust; it is the third most abundant element after oxygen and silicon and the most abundant metal in the crust.";
		} else if (element.name == "Si") {
				textInformation.text = "Silicon is a chemical element with symbol Si and atomic number 14. It is a hard and brittle crystalline solid with a blue-grey metallic lustre; and it is a tetravalent metalloid and semiconductor. It is a member of group 14 in the periodic table: carbon is above it; and germanium, tin, and lead are below it.";
		} else if (element.name == "P") {
				textInformation.text = "Phosphorus is a chemical element with symbol P and atomic number 15. Elemental phosphorus exists in two major forms, white phosphorus and red phosphorus, but because it is highly reactive, phosphorus is never found as a free element on Earth. ";
		} else if (element.name == "S") {
				textInformation.text = "Sulfur or sulphur is a chemical element with symbol S and atomic number 16. It is abundant, multivalent, and nonmetallic. Under normal conditions, sulfur atoms form cyclic octatomic molecules with a chemical formula S8. Elemental sulfur is a bright yellow, crystalline solid at room temperature.";
		} else if (element.name == "Cl") {
				textInformation.text = "Chlorine is a chemical element with symbol Cl and atomic number 17. The second-lightest of the halogens, it appears between fluorine and bromine in the periodic table and its properties are mostly intermediate between them. ";
		} else if (element.name == "Ar") {
				textInformation.text = "Argon is a chemical element with symbol Ar and atomic number 18. It is in group 18 of the periodic table and is a noble gas. Argon is the third-most abundant gas in the Earth's atmosphere, at 0.934% (9340 ppmv).";
		} else if (element.name == "Ga") {
				textInformation.text = "Gallium is a chemical element with symbol Ga and atomic number 31. Elemental gallium is a soft, silvery blue metal at standard temperature and pressure; however in its liquid state it becomes silvery white. Since its discovery in 1875, gallium has been used to make alloys with low melting points.";
		} else if (element.name == "Ge") {
				textInformation.text = "Germanium is a chemical element with symbol Ge and atomic number 32. It is a lustrous, hard-brittle, grayish-white metalloid in the carbon group, chemically similar to its group neighbours silicon and tin. Pure germanium is a semiconductor with an appearance similar to elemental silicon.";
		} else if (element.name == "As") {
				textInformation.text = "Arsenic is a chemical element with symbol As and atomic number 33. Arsenic occurs in many minerals, usually in combination with sulfur and metals, but also as a pure elemental crystal. Arsenic is a metalloid. It has various allotropes, but only the gray form is important to industry.";
		} else if (element.name == "Se") {
				textInformation.text = "Selenium is a chemical element with symbol Se and atomic number 34. It is a nonmetal (more rarely considered a metalloid) with properties that are intermediate between the elements above and below in the periodic table, sulfur and tellurium, and also has similarities to arsenic.";
		} else if (element.name == "Br") {
				textInformation.text = "Bromine is a chemical element with symbol Br and atomic number 35. It is the third-lightest halogen, and is a fuming liquid with a deep red color. At room temperature, Bromine evaporates readily to form a red to amber coloured gas.";
		} else if (element.name == "Kr") {
				textInformation.text = "Krypton is a chemical element with symbol Kr and atomic number 36. It is a member of group 18 (noble gases) elements. A colorless, odorless, tasteless noble gas, krypton occurs in trace amounts in the atmosphere and is often used with other rare gases in fluorescent lamps.";
		} else if (element.name == "In") {
				textInformation.text = "Indium is a chemical element with symbol In and atomic number 49. Indium is the softest metal that is not considered to be an alkali metal. It is a silvery-white metal that resembles Tin(Sn) in appearance. It is a post-transition metal that makes up 0.21 parts per million of the Earth's crust.";
		} else if (element.name == "Sn") {
				textInformation.text = "Tin is a chemical element with the symbol Sn (from Latin: stannum) and atomic number 50. Tin is a silvery white metal that characteristicly has a faint yellow hue due to slight oxidation. Tin, like indium, is soft enough to be cut without much force.";
		} else if (element.name == "Sb") {
				textInformation.text = "Antimony is a chemical element with symbol Sb (from Latin: stibium) and atomic number 51. A lustrous gray metalloid, it is found in nature mainly as the sulfide mineral stibnite (Sb2S3). Antimony compounds have been known since ancient times and were powdered for use as medicine and cosmetics.";
		} else if (element.name == "Te") {
				textInformation.text = "Tellurium is a chemical element with symbol Te and atomic number 52. It is a brittle, mildly toxic, rare, silver-white metalloid. Tellurium is chemically related to selenium and sulfur, all three of which are chalcogens. It is occasionally found in native form as elemental crystals.";
		} else if (element.name == "I") {
				textInformation.text = "Iodine is a chemical element with symbol I and atomic number 53. The heaviest of the stable halogens, it exists as a lustrous, purple-black non-metallic solid at standard conditions that melts to form a deep violet liquid at 114 degrees Celsius, and boils to a violet gas at 184 degrees Celsius.";
		} else if (element.name == "Xe") {
				textInformation.text = "Xenon is a chemical element with symbol Xe and atomic number 54. It is a colorless, dense, odorless noble gas found in the Earth's atmosphere in trace amounts. Although generally unreactive, xenon can undergo a few chemical reactions such as the formation of xenon hexafluoroplatinate.";
		} else if (element.name == "Tl") {
				textInformation.text = "Thallium is a chemical element with symbol Tl and atomic number 81. It is a gray post-transition metal that is not found free in nature. When isolated, thallium resembles tin, but discolors when exposed to air. Ittends to oxidize to the +3 and +1 oxidation states as ionic salts.";
		} else if (element.name == "Pb") {
				textInformation.text = "Lead is a chemical element with symbol Pb (from the Latin plumbum) and atomic number 82. It is a heavy metal that is denser than most common materials. Lead is soft and malleable, and also has a relatively low melting point. When freshly cut, lead is silvery with a hint of blue.";
		} else if (element.name == "Bi") {
				textInformation.text = "Bismuth is a chemical element with symbol Bi and atomic number 83. It is a pentavalent post-transition metal and one of the pnictogens with chemical properties resembling its lighter homologs arsenic and antimony. Elemental bismuth may occur naturally, although its sulfide and oxide form important commercial ores.";
		} else if (element.name == "Po") {
				textInformation.text = "Polonium is a chemical element with symbol Po and atomic number 84. A rare and highly radioactive metal with no stable isotopes, polonium is chemically similar to selenium and tellurium, though its metallic character resembles that of its horizontal neighbors in the periodic table: thallium, lead, and bismuth.";
		} else if (element.name == "At") {
				textInformation.text = "Astatine is a radioactive chemical element with symbol At and atomic number 85. It is the rarest naturally occurring element in the Earth's crust, occurring only as the decay product of various heavier elements. All of astatine's isotopes are short-lived; the most stable is astatine-210, with a half-life of 8.1h.";
		} else if (element.name == "Rn") {
				textInformation.text = "Radon is a chemical element with symbol Rn and atomic number 86. It is a radioactive, colorless, odorless, tasteless noble gas. Its most stable isotope, 222Rn, has a half-life of only 3.8 days, making radon one of the rarest elements since it decays away so quickly.";
		} else if (element.name == "Nh") {
				textInformation.text = "Nihonium is a synthetic chemical element with the symbol Nh and atomic number 113. It is extremely radioactive; its most stable known isotope, nihonium-286, has a half-life of about 10 seconds. In the periodic table, nihonium is a transactinide element in the p-block. It is a member of period 7 and group 13 .";
		} else if (element.name == "Fl") {
				textInformation.text = "Flerovium is a superheavy artificial chemical element with symbol Fl and atomic number 114. It is an extremely radioactive synthetic element. In the periodic table of the elements, it is a transactinide element in the p-block.";
		} else if (element.name == "Mc") {
				textInformation.text = "Moscovium is a synthetic chemical element with symbol Mc and atomic number 115. It was first synthesized in 2003 by a joint team of Russian and American scientists at the Joint Institute for Nuclear Research (JINR) in Dubna, Russia.";
		} else if (element.name == "Lv") {
				textInformation.text = "Livermorium is a synthetic chemical element with symbol Lv and has an atomic number of 116. It is an extremely radioactive element that has only been created in the laboratory and has not been observed in nature. In the periodic table, it is a p-block transactinide element.";
		} else if (element.name == "Ts") {
				textInformation.text = "Tennessine is a synthetic chemical element with symbol Ts and atomic number 117. It is the second-heaviest known element and the penultimate element of the 7th period of the periodic table. Some of its properties may significantly differ from those of the halogens due to relativistic effects.";
		} else if (element.name == "Og") {
				textInformation.text = "Oganesson is a synthetic chemical element with symbol Og and atomic number 118. Oganesson has the highest atomic number and highest atomic mass of all known elements. The radioactive oganesson atom is very unstable, and since 2005, only five (possibly six) atoms of the nuclide 294Og have been detected.";
		} else if (element.name == "Lu") {
				textInformation.text = "Lutetium is a chemical element with symbol Lu and atomic number 71. It is a silvery white metal, which resists corrosion in dry air, but not in moist air. Lutetium is the last element in the lanthanide series, and it is traditionally counted among the rare earths.";
		} else if (element.name == "Lr") {
				textInformation.text = "Lawrencium is a synthetic chemical element with symbol Lr (formerly Lw) and atomic number 103. A radioactive metal, lawrencium is the eleventh transuranic element and is also the final member of the actinide series.";
		} else if (element.name == "Yb") {
				textInformation.text = "Ytterbium is a chemical element with symbol Yb and atomic number 70. It is the fourteenth and penultimate element in the lanthanide series, which is the basis of the relative stability of its +2 oxidation state. Natural ytterbium is a mixture of seven stable isotopes.";
		} else if (element.name == "No") {
				textInformation.text = "Nobelium is a synthetic chemical element with symbol No and atomic number 102. It is named in honor of Alfred Nobel, the inventor of dynamite and benefactor of science. A radioactive metal, it is the tenth transuranic element and is the penultimate member of the actinide series.";
		} else if (element.name == "Tm") {
				textInformation.text = "Thulium is a chemical element with symbol Tm and atomic number 69. It is the thirteenth and third-last element in the lanthanide series. Like the other lanthanides, the most common oxidation state is +3, seen in its oxide, halides and other compounds.";
		} else if (element.name == "Md") {
				textInformation.text = "Mendelevium is a synthetic element with chemical symbol Md (formerly Mv) and atomic number 101. A metallic radioactive transuranic element in the actinide series, it is the first element that currently cannot be produced in macroscopic quantities through neutron bombardment of lighter elements.";
		} else if (element.name == "Er") {
				textInformation.text = "Erbium is a chemical element with symbol Er and atomic number 68. A silvery-white solid metal when artificially isolated, natural erbium is always found in chemical combination with other elements. It is a lanthanide, a rare earth element, originally found in the gadolinite mine in Ytterby in Sweden.";
		} else if (element.name == "Fm") {
				textInformation.text = "Fermium is a synthetic element with symbol Fm and atomic number 100. It is an actinide and the heaviest element that can be formed by neutron bombardment of lighter elements, and hence the last element that can be prepared in macroscopic quantities, although pure fermium metal has not yet been prepared.";
		} else if (element.name == "Ho") {
				textInformation.text = "Holmium is a chemical element with symbol Ho and atomic number 67. Part of the lanthanide series, holmium is a rare-earth element. Holmium was discovered by Swedish chemist Per Theodor Cleve. Its oxide was first isolated from rare-earth ores in 1878.";
		} else if (element.name == "Es") {
				textInformation.text = "Einsteinium is a synthetic element with symbol Es and atomic number 99. A member of the actinide series, it is the seventh transuranic element. Einsteinium was discovered as a component of the debris of the first hydrogen bomb explosion in 1952.";
		} else if (element.name == "Dy") {
				textInformation.text = "Dysprosium is a chemical element with symbol Dy and atomic number 66. It is a rare earth element with a metallic silver luster and is never found in nature as a free element. Naturally occurring dysprosium is composed of seven isotopes, the most abundant of which is 164Dy.";
		} else if (element.name == "Cf") {
				textInformation.text = "Californium is a radioactive chemical element with symbol Cf and atomic number 98.  It is an actinide element and the sixth transuranium element to be synthesized. Californium is one of the few transuranium elements that have practical applications.";
		} else if (element.name == "Tb") {
				textInformation.text = "Terbium is a chemical element with symbol Tb and atomic number 65. It is a silvery-white, rare earth metal that is malleable, ductile, and soft enough to be cut with a knife. Most of the world's terbium supply is used in green phosphors.";
		} else if (element.name == "Bk") {
				textInformation.text = "Berkelium is a transuranic radioactive chemical element with symbol Bk and atomic number 97. It is a member of the actinide and transuranium element series. Berkelium is a soft, silvery-white, radioactive metal.";
		} else if (element.name == "Gd") {
				textInformation.text = "Gadolinium is a chemical element with symbol Gd and atomic number 64. Gadolinium is silvery-white metal when oxidation is removed. It is only slightly malleable and is a ductile rare-earth metal. Gadolinium reacts with atmospheric oxygen or moisture slowly to form a black coating.";
		} else if (element.name == "Cm") {
				textInformation.text = "Curium is a transuranic radioactive chemical element with symbol Cm and atomic number 96. Curium is a hard, dense, silvery metal with a relatively high melting point and boiling point for an actinide. It is used in production of heavier actinides.";
		} else if (element.name == "Eu") {
				textInformation.text = "Europium is a chemical element with symbol Eu and atomic number 63. Europium is the most reactive lanthanide by far, having to be stored under an inert fluid to protect it from atmospheric oxygen or moisture. Europium is one of the rarest of rare earth elements on Earth.";
		} else if (element.name == "Am") {
				textInformation.text = "Americium is a synthetic chemical element with symbol Am and atomic number 95. It is radioactive and a transuranic member of the actinide series, in the periodic table located under the lanthanide element europium, and thus by analogy was named after the Americas.";
		} else if (element.name == "Sm") {
				textInformation.text = "Samarium is a chemical element with symbol Sm and atomic number 62. It is a moderately hard silvery metal that slowly oxidizes in air. Being a typical member of the lanthanide series, samarium usually assumes the oxidation state +3. Samarium has no significant biological role but is only slightly toxic.";
		} else if (element.name == "Pu") {
				textInformation.text = "Plutonium is a radioactive chemical element with symbol Pu and atomic number 94. It is an actinide metal of silvery-gray appearance that tarnishes when exposed to air, and forms a dull coating when oxidized. The element normally exhibits six allotropes and four oxidation states.";
		} else if (element.name == "Np") {
				textInformation.text = "Neptunium is a chemical element with symbol Np and atomic number 93. A radioactive actinide metal, neptunium is the first transuranic element. Its position in the periodic table just after uranium, named after the planet Uranus, led to it being named after Neptune, the next planet beyond Uranus.";
		} else if (element.name == "Pm") {
				textInformation.text = "Promethium is a chemical element with symbol Pm and atomic number 61. All of its isotopes are radioactive; it is extremely rare, with only about 500-600 grams naturally occurring in Earth's crust at any given time. Chemically, promethium is a lanthanide.";
		} else if (element.name == "Nd") {
				textInformation.text = "Neodymium is a chemical element with symbol Nd and atomic number 60. Neodymium belongs to the lanthanide series and is a rare-earth element. It is a hard, slightly malleable silvery metal, that quickly tarnishes in air and moisture.";
		} else if (element.name == "U") {
				textInformation.text = "Uranium is a chemical element with symbol U and atomic number 92. It is a silvery-grey metal in the actinide series of the periodic table. A uranium atom has 92 protons and 92 electrons, of which 6 are valence electrons. It has the highest atomic weight of the primordially occurring elements.";
		} else if (element.name == "Pa") {
				textInformation.text = "Protactinium (formerly protoactinium) is a chemical element with symbol Pa and atomic number 91. It is a dense, silvery-gray actinide metal which readily reacts with oxygen, water vapor and inorganic acids.";
		} else if (element.name == "Pr") {
				textInformation.text = "Praseodymium is a chemical element with symbol Pr and atomic number 59. It is the third member of the lanthanide series and is traditionally considered to be one of the rare-earth metals. It is a soft, silvery, malleable and ductile metal, valued for its magnetic, chemical, and optical properties.";
		} else if (element.name == "Ce") {
				textInformation.text = "Cerium is a chemical element with symbol Ce and atomic number 58. Cerium is a soft, ductile and silvery-white metal that tarnishes when exposed to air, and it is soft enough to be cut with a knife. Cerium was the first of the lanthanides to be discovered.";
		} else if (element.name == "Th") {
				textInformation.text = "Thorium is a weakly radioactive metallic chemical element with symbol Th and atomic number 90. Thorium is silvery and tarnishes black when it is exposed to air, forming thorium dioxide; it is moderately hard, malleable, and has a high melting point.";
		}

		buttons.SetActive(false);
		informationPanel.SetActive(true);
	}

	public void onClosePanel () {
		informationPanel.SetActive(false);
		buttons.SetActive(true);
	}
}
