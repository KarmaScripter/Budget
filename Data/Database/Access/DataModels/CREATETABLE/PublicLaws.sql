CREATE TABLE PublicLaws
(
    PublicLawsId AUTOINCREMENT NOT NULL UNIQUE,
    LawNumber    TEXT(80) NULL DEFAULT NS,
    BillTitle    TEXT(80) NULL DEFAULT NS,
    EnactedDate  TEXT(80) NULL DEFAULT NS,
    Congress     TEXT(80) NULL DEFAULT NS,
    BFY          TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( PublicLawsId )
)