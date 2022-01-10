-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 09 Sty 2022, 18:59
-- Wersja serwera: 10.4.22-MariaDB
-- Wersja PHP: 7.4.27

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
-- Struktura tabeli dla tabeli `czynnosci`
--

CREATE TABLE `czynnosci` (
  `id_czynnosci` int(11) NOT NULL,
  `nazwa_czynnosci` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `czynnosci`
--

INSERT INTO `czynnosci` (`id_czynnosci`, `nazwa_czynnosci`) VALUES
(1, 'Tankowanie'),
(2, 'Płyn do spryskiwaczy');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `eksploatacja`
--

CREATE TABLE `eksploatacja` (
  `id_eksploatacji` int(11) NOT NULL,
  `id_pojazdu` int(11) DEFAULT NULL,
  `nazwa_czynnsci` varchar(255) DEFAULT NULL,
  `koszt` float(6,2) DEFAULT NULL,
  `id_pracownika` int(11) DEFAULT NULL,
  `data_wykonania` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `eksploatacja`
--

INSERT INTO `eksploatacja` (`id_eksploatacji`, `id_pojazdu`, `nazwa_czynnsci`, `koszt`, `id_pracownika`, `data_wykonania`) VALUES
(4, 17, 'Płyn do spryskiwaczy', 490.00, 2, '2022-01-06');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `element_wyposazenia`
--

CREATE TABLE `element_wyposazenia` (
  `id_wyposazenia` int(11) NOT NULL,
  `nazwa_wypozazenia` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `element_wyposazenia`
--

INSERT INTO `element_wyposazenia` (`id_wyposazenia`, `nazwa_wypozazenia`) VALUES
(1, 'Standartowe'),
(2, 'Niestandartowe');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `marka`
--

CREATE TABLE `marka` (
  `id_marki` int(11) NOT NULL,
  `nazwa_marki` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `marka`
--

INSERT INTO `marka` (`id_marki`, `nazwa_marki`) VALUES
(1, 'Audi'),
(2, 'BMW');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `model`
--

CREATE TABLE `model` (
  `id_modelu` int(11) NOT NULL,
  `nazwa_modelu` varchar(255) DEFAULT NULL,
  `id_marki` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `model`
--

INSERT INTO `model` (`id_modelu`, `nazwa_modelu`, `id_marki`) VALUES
(5, 'A4', 1),
(6, 'Q5', 1),
(7, 'i3', 2),
(8, 'i8', 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `opiekun`
--

CREATE TABLE `opiekun` (
  `id_opiekuna` int(11) NOT NULL,
  `id_pracownika` int(11) NOT NULL,
  `id_pojazdu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `opiekun`
--

INSERT INTO `opiekun` (`id_opiekuna`, `id_pracownika`, `id_pojazdu`) VALUES
(3, 2, 16),
(4, 4, 17);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pojazd`
--

CREATE TABLE `pojazd` (
  `id_pojazdu` int(11) NOT NULL,
  `nr_rejestracyjny` varchar(255) NOT NULL,
  `vin` varchar(255) DEFAULT NULL,
  `id_modelu` int(11) DEFAULT NULL,
  `id_typu_pojazdu` int(11) DEFAULT NULL,
  `rok_produkcji` int(11) DEFAULT NULL,
  `przebieg` int(11) DEFAULT NULL,
  `id_przeznaczenia` int(11) DEFAULT NULL,
  `id_wyposazenia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `pojazd`
--

INSERT INTO `pojazd` (`id_pojazdu`, `nr_rejestracyjny`, `vin`, `id_modelu`, `id_typu_pojazdu`, `rok_produkcji`, `przebieg`, `id_przeznaczenia`, `id_wyposazenia`) VALUES
(1, 'TEST1', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, 'TEST2', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(16, 'test321', '123', 7, 1, 2013, 123, 1, 1),
(17, 'SGJ2GMD', '123123123123', 7, 1, 1990, 12222, 1, 1);

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
  `adres` varchar(255) DEFAULT NULL,
  `login` varchar(255) DEFAULT NULL,
  `haslo` varchar(255) NOT NULL,
  `miejscowosc` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `pracownik`
--

INSERT INTO `pracownik` (`id_pracownika`, `imie`, `nazwisko`, `nr_tel`, `pesel`, `id_stanowiska`, `adres`, `login`, `haslo`, `miejscowosc`) VALUES
(1, 'superadmin', 'superadmin', 123456789, 1234567890, 1, 'super 1', 'superadmin', '123', 'Superancka'),
(2, 'Test123', 'Testowy321', 123123123, 2147483647, 1, 'testa 12', 'test', '123', 'Testowo'),
(4, 'jan', 'kurwiszon', 2147483647, 997, 2, 'chujowice', 'jan', '123', 'warszawa');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `przeznaczenie`
--

CREATE TABLE `przeznaczenie` (
  `id_przeznaczenia` int(11) NOT NULL,
  `nazwa_przeznaczenia` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `przeznaczenie`
--

INSERT INTO `przeznaczenie` (`id_przeznaczenia`, `nazwa_przeznaczenia`) VALUES
(1, 'Samochód służbowy');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `serwis`
--

CREATE TABLE `serwis` (
  `id_serwisu` int(11) NOT NULL,
  `id_pojazdu` int(11) DEFAULT NULL,
  `data_ostatniego_przegladu` date DEFAULT NULL,
  `nazwa_serwisu` varchar(255) DEFAULT NULL,
  `id_uslugi` int(11) DEFAULT NULL,
  `koszt` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `serwis`
--

INSERT INTO `serwis` (`id_serwisu`, `id_pojazdu`, `data_ostatniego_przegladu`, `nazwa_serwisu`, `id_uslugi`, `koszt`) VALUES
(5, 17, '2022-01-06', 'jebaćgudysia', 1, 15),
(6, 1, '2022-01-09', 'przegladzimowy1', 2, 250);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `stanowisko`
--

CREATE TABLE `stanowisko` (
  `id_stanowiska` int(11) NOT NULL,
  `nazwa` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `stanowisko`
--

INSERT INTO `stanowisko` (`id_stanowiska`, `nazwa`) VALUES
(1, 'Super Admin'),
(2, 'Flotmistrz'),
(3, 'Pracownik'),
(4, 'Opiekun pojazdu');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ_pojazdu`
--

CREATE TABLE `typ_pojazdu` (
  `id_typu_pojazdu` int(11) NOT NULL,
  `nazwa_typu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `typ_pojazdu`
--

INSERT INTO `typ_pojazdu` (`id_typu_pojazdu`, `nazwa_typu`) VALUES
(1, 'Osobowy');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `usluga`
--

CREATE TABLE `usluga` (
  `id_uslugi` int(11) NOT NULL,
  `nazwa_uslugi` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `usluga`
--

INSERT INTO `usluga` (`id_uslugi`, `nazwa_uslugi`) VALUES
(1, 'lakierowanie'),
(2, 'wymiana opon');

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
-- Zrzut danych tabeli `wypozyczenia`
--

INSERT INTO `wypozyczenia` (`id_wypozyczenia`, `id_pojazdu`, `id_pracownika`, `data_od`, `data_do`, `powod`) VALUES
(1, 1, 2, '2022-01-06', '2022-01-12', 'test'),
(2, 1, 1, '2022-01-02', '2022-01-03', 'test'),
(3, 2, 2, '2022-01-06', '2022-01-07', 'TEST2'),
(4, 2, 2, '2021-12-28', '2022-01-01', 'test testu'),
(5, 2, 2, '2021-12-14', '2021-12-16', 'dasdsa'),
(6, 16, 2, '2022-01-06', '2022-01-21', 'do babci jade');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `czynnosci`
--
ALTER TABLE `czynnosci`
  ADD PRIMARY KEY (`id_czynnosci`);

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
  ADD PRIMARY KEY (`id_marki`);

--
-- Indeksy dla tabeli `model`
--
ALTER TABLE `model`
  ADD PRIMARY KEY (`id_modelu`),
  ADD KEY `id_marki` (`id_marki`);

--
-- Indeksy dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  ADD PRIMARY KEY (`id_opiekuna`),
  ADD KEY `id_pracownika` (`id_pracownika`),
  ADD KEY `id_pojazdu` (`id_pojazdu`);

--
-- Indeksy dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  ADD PRIMARY KEY (`id_pojazdu`),
  ADD KEY `id_marki` (`id_modelu`),
  ADD KEY `id_typu_pojazdu` (`id_typu_pojazdu`),
  ADD KEY `id_przeznaczenia` (`id_przeznaczenia`),
  ADD KEY `id_wyposazenia` (`id_wyposazenia`);

--
-- Indeksy dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  ADD PRIMARY KEY (`id_pracownika`),
  ADD UNIQUE KEY `login` (`login`),
  ADD KEY `id_stanowiska` (`id_stanowiska`),
  ADD KEY `id_miejsca_zamieszkania` (`adres`);

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
-- AUTO_INCREMENT dla tabeli `czynnosci`
--
ALTER TABLE `czynnosci`
  MODIFY `id_czynnosci` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `eksploatacja`
--
ALTER TABLE `eksploatacja`
  MODIFY `id_eksploatacji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `element_wyposazenia`
--
ALTER TABLE `element_wyposazenia`
  MODIFY `id_wyposazenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `marka`
--
ALTER TABLE `marka`
  MODIFY `id_marki` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `model`
--
ALTER TABLE `model`
  MODIFY `id_modelu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  MODIFY `id_opiekuna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  MODIFY `id_pojazdu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  MODIFY `id_pracownika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `przeznaczenie`
--
ALTER TABLE `przeznaczenie`
  MODIFY `id_przeznaczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `serwis`
--
ALTER TABLE `serwis`
  MODIFY `id_serwisu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT dla tabeli `stanowisko`
--
ALTER TABLE `stanowisko`
  MODIFY `id_stanowiska` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `typ_pojazdu`
--
ALTER TABLE `typ_pojazdu`
  MODIFY `id_typu_pojazdu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `usluga`
--
ALTER TABLE `usluga`
  MODIFY `id_uslugi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `wypozyczenia`
--
ALTER TABLE `wypozyczenia`
  MODIFY `id_wypozyczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

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
-- Ograniczenia dla tabeli `model`
--
ALTER TABLE `model`
  ADD CONSTRAINT `model_ibfk_1` FOREIGN KEY (`id_marki`) REFERENCES `marka` (`id_marki`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  ADD CONSTRAINT `opiekun_ibfk_1` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `opiekun_ibfk_2` FOREIGN KEY (`id_pojazdu`) REFERENCES `pojazd` (`id_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `pojazd`
--
ALTER TABLE `pojazd`
  ADD CONSTRAINT `pojazd_ibfk_2` FOREIGN KEY (`id_wyposazenia`) REFERENCES `element_wyposazenia` (`id_wyposazenia`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_4` FOREIGN KEY (`id_typu_pojazdu`) REFERENCES `typ_pojazdu` (`id_typu_pojazdu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_5` FOREIGN KEY (`id_przeznaczenia`) REFERENCES `przeznaczenie` (`id_przeznaczenia`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pojazd_ibfk_6` FOREIGN KEY (`id_modelu`) REFERENCES `model` (`id_modelu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
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
