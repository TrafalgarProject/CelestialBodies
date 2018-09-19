using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SSLN {

	public string bodiesName;
	public string bodiesName_ContextMenu;
	public string Information;

    public void BodiesName(string Name, string NameB, string NameF, string NameHD, string NameHIP)
    {
        if (Name.ToString() != "0")
        {
            bodiesName_ContextMenu = Name;
            if (NameB.ToString() != "0")
            {
                if (NameF.ToString() != "0")
                {
                    if (NameHD.ToString() != "0")
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + NameB + " / " + "F " + NameF + " / " + "HD " + NameHD + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + NameB + " / " + "F " + NameF + " / " + "HD " + NameHD;
                        }
                    }
                    else
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + NameB + " / " + "F " + NameF + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + NameB + " / " + "F " + NameF;
                        }
                    }
                }
                else
                {
                    if (NameHD.ToString() != "0")
                    {
                        if (NameHIP != "0")
                        {
                            bodiesName = Name + " / " + NameB + " / " + "HD " + NameHD + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + NameB + " / " + "HD " + NameHD;
                        }
                    }
                    else
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + NameB + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + NameB;
                        }
                    }
                }
            }
            else
            {
                if (NameF.ToString() != "0")
                {
                    if (NameHD != "0")
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + "F " + NameF + " / " + "HD " + NameHD + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + "F " + NameF + " / " + "HD " + NameHD;
                        }
                    }
                    else
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + "F " + NameF + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + "F " + NameF;
                        }
                    }
                }
                else
                {
                    if (NameHD.ToString() != "0")
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + "HD " + NameHD + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name + " / " + "HD " + NameHD;
                        }
                    }
                    else
                    {
                        if (NameHIP.ToString() != "0")
                        {
                            bodiesName = Name + " / " + "HIP " + NameHIP;
                        }
                        else
                        {
                            bodiesName = Name;
                        }
                    }
                }
            }
        }
        else {
            bodiesName = "Данные отсутствуют";
            bodiesName_ContextMenu = "Данные отсутствуют";
        }
    }

	public void StarInfo(string TypeObj, string Value, string Distance, string SpectralClass, string Radius, string Temperature, string Lumin, string Rotation)
	{
		if (Value.ToString() != "0")
		{
			if (Distance.ToString() != "0")
			{
				if (SpectralClass.ToString() != "0")
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				}
				else
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Расстояние: " + Distance + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				} // SpectralClass
			}
			else
			{
				if (SpectralClass.ToString() != "0")
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + 
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + 
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Класс: " + SpectralClass + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				}
				else
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + 
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Видимая звёздная величина: " + Value + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				} // SpectralClass
			} // Distance
		}
		else
		{

			if (Distance.ToString() != "0")
			{
				if (SpectralClass.ToString() != "0")
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" +
                                        "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Класс: " + SpectralClass + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				}
				else
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Расстояние: " + Distance + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				} // SpectralClass
			}
			else
			{
				if (SpectralClass.ToString() != "0")
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Класс: " + SpectralClass + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				}
				else
				{
					if (Radius.ToString() != "0")
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Радиус: " + Radius + "\n";
								} // Rotation
							} // Lumin
						} // Temperature
					}
					else
					{
						if (Temperature.ToString() != "0")
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Температура: " + Temperature + "\n" +
										"Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Температура: " + Temperature + "\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Температура: " + Temperature + "\n";
								} // Rotation
							} // Lumin
						}
						else
						{
							if (Lumin.ToString() != "0")
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Светимость: " + Lumin + " L"+"\n" +
										"Вращение: " + Rotation;
								}
								else
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Светимость: " + Lumin + " L"+"\n";
								} // Rotation
							}
							else
							{
								if (Rotation.ToString() != "0")
								{
									Information = "Тип объекта: " + TypeObj + "\n" + "Вращение: " + Rotation;
								}
								else
								{
									Information = null;
								} // Rotation
							} // Lumin
						} // Temperature
					} // Radius
				} // SpectralClass
			} // Distance
		}
	}

	public void PlanetsInformation(string TypeObj, string ParentStar,string palanetsNameSpectalClass, string planetsDistance, string planetsDiameter, string planetsPeriodRotation, string planetsTemperature, int planetsMoonsCount)
	{
		if (palanetsNameSpectalClass.ToString() != "0")
		{


			if (planetsDistance.ToString() != "0")
			{

				if (planetsDiameter.ToString() != "0")
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n";
							}

						}

					}

				}
				else
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n"+
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" + "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Расстояние: " + planetsDistance + "\n";
							}

						}

					}

				}


			}
			else
			{
				//-----

				if (planetsDiameter.ToString() != "0")
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Диаметр: " + planetsDiameter + "\n";
							}

						}

					}

				}
				else
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Спектральный класс: " + palanetsNameSpectalClass + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n"+
                                    "Родительская звезда: " + ParentStar + "\n"
                                    + "Спектральный класс: " + palanetsNameSpectalClass + "\n";
							}

						}

					}

				}
				//

			}


		}
		else
		{
			////

			if (planetsDistance.ToString() != "0")
			{

				if (planetsDiameter.ToString() != "0")
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Диаметр: " + planetsDiameter + "\n";
							}

						}

					}

				}
				else
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Расстояние: " + planetsDistance + "\n";
							}

						}

					}

				}


			}
			else
			{
				//-----

				if (planetsDiameter.ToString() != "0")
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Диаметр: " + planetsDiameter + "\n";
							}

						}

					}

				}
				else
				{

					if (planetsPeriodRotation.ToString() != "0")
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Вращение: " + planetsPeriodRotation + "\n" +
									"Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Вращение: " + planetsPeriodRotation + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Вращение: " + planetsPeriodRotation + "\n";
							}

						}
					}
					else
					{

						if (planetsTemperature.ToString() != "0")
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Температура: " + planetsTemperature + "\n" +
									"Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Температура: " + planetsTemperature + "\n";
							}

						}
						else
						{

							if (planetsMoonsCount.ToString() != "0")
							{
								Information = "Тип объекта: " + TypeObj + "\n" +
                                    "Родительская звезда: " + ParentStar + "\n" +
                                    "Колличество лун: " + planetsMoonsCount + "\n";
							}
							else
							{
								Information = null;
							}

						}

					}

				}
				//

			}

			////
		}
	}

}
