﻿/*
    C# application for administration of gym/fitness memberships etc.
    Copyright (C)2018/2019 Bruno Fištrek

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace Fitness.Database
{
    [DatabaseTable("korisnici")]
    public struct Korisnik
    {
        public int Index;
        public int BrojIskaznice;
        public string Ime;
        public string Prezime;
        public string DatumUclanjenja;
        public string DatumRodenja;
        public string ZadnjiDolazak;
        public string Napomena;
        public string AktivnaUsluga;
        public string AktivnaOd;
        public string AktivnaDo;
        public int Dolazaka;
    }
}