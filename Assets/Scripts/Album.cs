using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Album
{
    //Define on Create
    private string name;
    private Artist artist;
    //Define on Songs added
    List<Song> songs;
    private uint Year;
    private Image bitImage;
    public Album(string name, Artist art, Image image)
    {
        this.setName(name);
        this.setArtist(art);
        this.SetBitImage(image);
        this.songs = new List<Song>();
    }
    public Image GetBitImage()
    {
        return this.bitImage;
    }

    public void SetBitImage(Image value)
    {
        this.bitImage = value;
    }

    public List<Song> getSongs()
    {
        return songs;
    }

    public void setSongs(List<Song> songs)
    {
        this.songs = songs;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public uint getYear()
    {
        return Year;
    }

    public void setYear(uint year)
    {
        Year = year;
    }

    public Artist getArtist()
    {
        return artist;
    }

    public void setArtist(Artist artist)
    {
        this.artist = artist;
    }
}

