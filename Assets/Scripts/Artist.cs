using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artist
{
    private Image image;
    private string Name;
    private List<Album> Albums;



    public Artist(string name, Image Image)
    {
        this.setName(name);
        this.setAlbums(new List<Album>());
        this.image = Image;

    }

    //Getters y Setters
    public string getName()
    {
        return Name;
    }
    public void setName(string name)
    {
        Name = name;
    }
    public List<Album> getAlbums()
    {
        return Albums;
    }
    public void setAlbums(List<Album> albums)
    {
        Albums = albums;
    }

    public Image GetImage()
    {
        return image;
    }

    public void SetImage(Image value)
    {
        image = value;
    }
}
