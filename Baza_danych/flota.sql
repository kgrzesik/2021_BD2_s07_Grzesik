-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Czas generowania: 02 Gru 2021, 15:25
-- Wersja serwera: 10.4.22-MariaDB
-- Wersja PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `flota`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `eksploatacja`
--

CREATE TABLE `eksploatacja` (
  `id_eksploatacji` int(11) NOT NULL,
  `id_pojazdu` int(11) DEFAULT NULL,
  `nazwa_czynnsci` varchar(255) DEFAULT NULL,
  `koszt` float(6,2) DEFAULT NULL,
  `id_pracownika` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `element_wyposazenia`
--

CREATE TABLE `element_wyposazenia` (
  `id_wyposazenia` int(11) NOT NULL,
  `nazwa_wypozazenia` varchar(255) NOT NULL,
  `czy_wystepuje` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `marka`
--

CREATE TABLE `marka` (
  `id_marki` int(11) NOT NULL,
  `nazwa_marki` varchar(255) DEFAULT NULL,
  `id_modelu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `miejsce_zamieszkania`
--

CREATE TABLE `miejsce_zamieszkania` (
  `id_miejsca_zamieszkania` int(11) NOT NULL,
  `miejscowosc` varchar(255) DEFAULT NULL,
  `ulica` varchar(255) DEFAULT NULL,
  `nr_domu` varchar(255) DEFAULT NULL,
  `nr_lokalu` varchar(255) DEFAULT NULL,
  `kod_pocztowy` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `model`
--

CREATE TABLE `model` (
  `id_modelu` int(11) NOT NULL,
  `nazwa_modelu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `opiekun`
--

CREATE TABLE `opiekun` (
  `id_opiekuna` int(11) NOT NULL,
  `id_pracownika` int(11) NOT NULL,
  `czy_aktualny` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pojazd`
--

CREATE TABLE `pojazd` (
  `id_pojazdu` int(11) NOT NULL,
  `nr_rejestracyjny` varchar(255) NOT NULL,
  `vin` varchar(255) DEFAULT NULL,
  `id_marki` int(11) DEFAULT NULL,
  `id_typu_pojazdu` int(11) DEFAULT NULL,
  `rok_produkcji` int(11) DEFAULT NULL,
  `przebieg` int(11) DEFAULT NULL,
  `id_przeznaczenia` int(11) DEFAULT NULL,
  `id_wyposazenia` int(11) DEFAULT NULL,
  `id_opiekuna` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `pojazd`
--

INSERT INTO `pojazd` (`id_pojazdu`, `nr_rejestracyjny`, `vin`, `id_marki`, `id_typu_pojazdu`, `rok_produkcji`, `przebieg`, `id_przeznaczenia`, `id_wyposazenia`, `id_opiekuna`) VALUES
(1, 'TEST1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, 'TEST2', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownik`
--

CREATE TABLE `pracownik` (
  `id_pracownika` int(11) NOT NULL,
  `imie` varchar(255) NOT NULL,
  `nazwisko` varchar(255) NOT NULL,
  `nr_tel` int(11) NOT NULL,
  `pesel` int(11) NOT NULL,
  `id_stanowiska` int(11) DEFAULT NULL,
  `id_miejsca_zamieszkania` int(11) DEFAULT NULL,
  `login` varchar(255) DEFAULT NULL,
  `haslo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `pracownik`
--

INSERT INTO `pracownik` (`id_pracownika`, `imie`, `nazwisko`, `nr_tel`, `pesel`, `id_stanowiska`, `id_miejsca_zamieszkania`, `login`, `haslo`) VALUES
(1, 'superadmin', 'superadmin', 123456789, 1234567890, NULL, NULL, 'superadmin', '123');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `przeznaczenie`
--

CREATE TABLE `przeznaczenie` (
  `id_przeznaczenia` int(11) NOT NULL,
  `nazwa_przeznaczenia` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `serwis`
--

CREATE TABLE `serwis` (
  `id_serwisu` int(11) NOT NULL,
  `id_pojazdu` int(11) DEFAULT NULL,
  `data_ostatniego_przegladu` date DEFAULT NULL,
  `nazwa_serwisu` varchar(255) DEFAULT NULL,
  `id_uslugi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `stanowisko`
--

CREATE TABLE `stanowisko` (
  `id_stanowiska` int(11) NOT NULL,
  `nazwa` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ_pojazdu`
--

CREATE TABLE `typ_pojazdu` (
  `id_typu_pojazdu` int(11) NOT NULL,
  `nazwa_typu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `usluga`
--

CREATE TABLE `usluga` (
  `id_uslugi` int(11) NOT NULL,
  `nazwa_uslugi` varchar(255) DEFAULT NULL,
  `koszt` float(6,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wypozyczenia`
--

CREATE TABLE `wypozyczenia` (
  `id_wypozyczenia` int(11) NOT NULL,
  `id_pojazdu` int(11) DEFAULT NULL,
  `id_pracownika` int(11) DEFAULT NULL,
  `data_od` date DEFAULT NULL,
  `data_do` date DEFAULT NULL,
  `powod` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `eksploatacja`
--
ALTER TABLE `eksploatacja`
  ADD PRIMARY KEY (`id_eksploatacji`),
  ADD KEY `id_pojazdu` (`id_pojazdu`),
  ADD KEY `id_pracownika` (`id_pracownika`);

--
-- Indeksy dla tabeli `element_wyposazenia`
--
ALTER TABLE `element_wyposazenia`
  ADD PRIMARY KEY (`id_wyposazenia`);

--
-- Indeksy dla tabeli `marka`
--
ALTER TABLE `marka`
  ADD PRIMARY KEY (`id_marki`),
  ADD KEY `id_modelu` (`id_modelu`);

--
-- Indeksy dla tabeli `miejsce_zamieszkania`
--
ALTER TABLE `miejsce_zamieszkania`
  ADD PRIMARY KEY (`id_miejsca_zamieszkania`);

--
-- Indeksy dla tabeli `model`
--
ALTER TABLE `model`
  ADD PRIMARY KEY (`id_modelu`);

--
-- Indeksy dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  ADD PRIMARY KEY (`id_opiekuna`),
  ADD KEY `id_pracownika` (`id_pracownika`);

--
-- Indeksy dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  ADD PRIMARY KEY (`id_pojazdu`),
  ADD KEY `id_marki` (`id_marki`),
  ADD KEY `id_typu_pojazdu` (`id_typu_pojazdu`),
  ADD KEY `id_przeznaczenia` (`id_przeznaczenia`),
  ADD KEY `id_wyposazenia` (`id_wyposazenia`),
  ADD KEY `id_opiekuna` (`id_opiekuna`);

--
-- Indeksy dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  ADD PRIMARY KEY (`id_pracownika`),
  ADD KEY `id_stanowiska` (`id_stanowiska`),
  ADD KEY `id_miejsca_zamieszkania` (`id_miejsca_zamieszkania`);

--
-- Indeksy dla tabeli `przeznaczenie`
--
ALTER TABLE `przeznaczenie`
  ADD PRIMARY KEY (`id_przeznaczenia`);

--
-- Indeksy dla tabeli `serwis`
--
ALTER TABLE `serwis`
  ADD PRIMARY KEY (`id_serwisu`),
  ADD KEY `id_pojazdu` (`id_pojazdu`),
  ADD KEY `id_uslugi` (`id_uslugi`);

--
-- Indeksy dla tabeli `stanowisko`
--
ALTER TABLE `stanowisko`
  ADD PRIMARY KEY (`id_stanowiska`);

--
-- Indeksy dla tabeli `typ_pojazdu`
--
ALTER TABLE `typ_pojazdu`
  ADD PRIMARY KEY (`id_typu_pojazdu`);

--
-- Indeksy dla tabeli `usluga`
--
ALTER TABLE `usluga`
  ADD PRIMARY KEY (`id_uslugi`);

--
-- Indeksy dla tabeli `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  ADD PRIMARY KEY (`id_wypozyczenia`),
  ADD KEY `id_pojazdu` (`id_pojazdu`),
  ADD KEY `id_pracownika` (`id_pracownika`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `eksploatacja`
--
ALTER TABLE `eksploatacja`
  MODIFY `id_eksploatacji` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `element_wyposazenia`
--
ALTER TABLE `element_wyposazenia`
  MODIFY `id_wyposazenia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `marka`
--
ALTER TABLE `marka`
  MODIFY `id_marki` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `miejsce_zamieszkania`
--
ALTER TABLE `miejsce_zamieszkania`
  MODIFY `id_miejsca_zamieszkania` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `model`
--
ALTER TABLE `model`
  MODIFY `id_modelu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  MODIFY `id_opiekuna` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  MODIFY `id_pojazdu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  MODIFY `id_pracownika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `przeznaczenie`
--
ALTER TABLE `przeznaczenie`
  MODIFY `id_przeznaczenia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `serwis`
--
ALTER TABLE `serwis`
  MODIFY `id_serwisu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `stanowisko`
--
ALTER TABLE `stanowisko`
  MODIFY `id_stanowiska` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `typ_pojazdu`
--
ALTER TABLE `typ_pojazdu`
  MODIFY `id_typu_pojazdu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `usluga`
--
ALTER TABLE `usluga`
  MODIFY `id_uslugi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  MODIFY `id_wypozyczenia` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `eksploatacja`
--
ALTER TABLE `eksploatacja`
  ADD CONSTRAINT `eksploatacja_ibfk_1` FOREIGN KEY (`id_pojazdu`) REFERENCES `pojazd` (`id_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `eksploatacja_ibfk_2` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `marka`
--
ALTER TABLE `marka`
  ADD CONSTRAINT `marka_ibfk_1` FOREIGN KEY (`id_modelu`) REFERENCES `model` (`id_modelu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  ADD CONSTRAINT `opiekun_ibfk_1` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  ADD CONSTRAINT `pojazd_ibfk_1` FOREIGN KEY (`id_marki`) REFERENCES `marka` (`id_marki`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_2` FOREIGN KEY (`id_wyposazenia`) REFERENCES `element_wyposazenia` (`id_wyposazenia`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_3` FOREIGN KEY (`id_opiekuna`) REFERENCES `opiekun` (`id_opiekuna`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_4` FOREIGN KEY (`id_typu_pojazdu`) REFERENCES `typ_pojazdu` (`id_typu_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_5` FOREIGN KEY (`id_przeznaczenia`) REFERENCES `przeznaczenie` (`id_przeznaczenia`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  ADD CONSTRAINT `pracownik_ibfk_1` FOREIGN KEY (`id_miejsca_zamieszkania`) REFERENCES `miejsce_zamieszkania` (`id_miejsca_zamieszkania`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pracownik_ibfk_2` FOREIGN KEY (`id_stanowiska`) REFERENCES `stanowisko` (`id_stanowiska`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `serwis`
--
ALTER TABLE `serwis`
  ADD CONSTRAINT `serwis_ibfk_1` FOREIGN KEY (`id_pojazdu`) REFERENCES `pojazd` (`id_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `serwis_ibfk_2` FOREIGN KEY (`id_uslugi`) REFERENCES `usluga` (`id_uslugi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  ADD CONSTRAINT `wypozyczenia_ibfk_1` FOREIGN KEY (`id_pojazdu`) REFERENCES `pojazd` (`id_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `wypozyczenia_ibfk_2` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
