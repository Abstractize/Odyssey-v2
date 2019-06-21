using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song
{
    private string URL;
    private string name;
    private Artist artist;//revisar después
    private Album album;//revisar después
    private uint year;
    private uint albumIndex;
    private uint disc;

    public uint GetDisc()
    {
        return this.disc;
    }

    public void SetDisc(uint value)
    {
        this.disc = value;
    }

    public Song(string song, Artist artist, Album album, uint year, uint disc, uint index, string URL)
    {
        this.setName(song);
        this.setArtist(artist);
        this.setAlbum(album);
        this.setYear(year);
        this.SetDisc(disc);
        this.setAlbumIndex(index);
        this.setURL(URL);
    }
    public int toInt(string str)
    {
        int value = System.Convert.ToInt32(str);
        return value;
    }
    //Getter y Setters
    public string getURL()
    {
        return URL;
    }

    public void setURL(string uRL)
    {
        URL = uRL;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public Artist getArtist()
    {
        return artist;
    }

    public void setArtist(Artist artist)
    {
        this.artist = artist;
    }

    public Album getAlbum()
    {
        return album;
    }

    public void setAlbum(Album album)
    {
        this.album = album;
    }

    public uint getYear()
    {
        return year;
    }

    public void setYear(uint year)
    {
        this.year = year;
    }

    public uint getAlbumIndex()
    {
        return albumIndex;
    }

    public void setAlbumIndex(uint albumIndex)
    {
        this.albumIndex = albumIndex;
    }
}
