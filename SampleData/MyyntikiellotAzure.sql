/****** Object:  Table [dbo].[MyyntikiellotAZURE]    Script Date: 8.1.2019 20.09.07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MyyntikiellotAZURE](
	[id] [int] NOT NULL,
	[julkaisu_pvm] [date] NULL,
	[tuotenimi] [varchar](255) NULL,
	[malli] [varchar](255) NULL,
	[tekniset_arvot] [varchar](255) NULL,
	[tuote_paaryhma_nimi] [varchar](100) NULL,
	[nimike] [varchar](255) NULL,
	[viivakoodi] [varchar](50) NULL,
	[vaaranlaji] [varchar](255) NULL,
	[tapaus_tulos] [varchar](255) NULL,
	[tapausnumero] [varchar](50) NULL,
	[tapauksen_kuvat] [varchar](255) NULL,
	[muut_tiedot] [varchar](500) NULL,
	[vastuutaho] [varchar](255) NULL,
	[asiakirjat] [varchar](255) NULL,
	[puutteet] [varchar](500) NULL,
	[paatos] [varchar](255) NULL,
 CONSTRAINT [PK_MyyntikiellotAZURE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO