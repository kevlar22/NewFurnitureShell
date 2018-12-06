﻿CREATE TABLE [dbo].[Matches] (
    [matchID] [int] NOT NULL IDENTITY,
    [sellerName] [nvarchar](max),
    [itemForSaleName] [nvarchar](max),
    [salePrice] [int] NOT NULL,
    [sellingCategory] [nvarchar](max),
    [image] [nvarchar](max),
    [buyerID] [int] NOT NULL,
    [requestID] [int] NOT NULL,
    [sellerID] [int] NOT NULL,
    [itemID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Matches] PRIMARY KEY ([matchID])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201812052320297_AutomaticMigration', N'DotNetAppSqlDb.Models.MyDatabaseContext',  0x1F8B0800000000000400D55CDD6EEBB811BE2FD0771074D516593BC9B969037B17AE9D14464F928338BB287A133012ED0895282D4565E3167DB25EF491FA0A1DFD5114A91F4AB2E42C0E70704C911F87A36F6644CEF0FCEF3FFF5DFCF0E1B9C63BA6A1E393A57935BB340D4C2CDF76C86169466CFFDD1FCD1FBEFFED6F16B7B6F761FC94F7FB12F78391245C9A6F8C0537F37968BD610F8533CFB1A81FFA7B36B37C6F8E6C7F7E7D79F9A7F9D5D51C0384095886B1788A08733C9CFC809F6B9F5838601172EF7D1BBB61D60E4F7609AAF1803C1C06C8C24B73E3B307CC5641B0FBD9DDBCCED201A6B1721D04C2ECB0BB370D4488CF1003516F7E0CF18E519F1C76013420F7F91860E8B7476E88B325DC14DD755773791DAF665E0CCCA1AC2864BED711F0EA4BA69EB93CBC97924DAE3E50E02D289A1DE355274A5C9A2BDBA638048DC973DDAC5D1AF7AB51F12C1B7861941F5F70560079E23F17C63A725944F192E08851E45E18DFA257D7B1FE8A8FCFFE3F305992C8754521414C78566A80A66FD40F3065C727BC2F8BFEB2DD98C6BC3C7E2E03F0E11563D3556E09FB726D1A0F200C7A7531E784A0911DF329FE0B26982286ED6F88314CE1956E6D9C685591429A13B84735266C0601F662CC720CF80596691AF7E8E32B2607F6B634E19FA671E77C603B6FC9707F240E18320C62346A9D669DAC67E44976A0573CFA2C7F7782612A5F05EC8544DE89055DCC0B5B6CB4508761EF0163FB09FF1CE190F5305519E18C364B5311B676779315864E65B111586CFB7CCD1816CC7CF0E9F8D6E439E41B752C3C4C5C0F7D7446E944E5F0CEA73BE4E27E34CE479F91C2B1187D424E3E6E52F20E8C3604FE1E9DB8C170D6DA38B4A813A4DF48238BEB78E830BE5246721BDAA67A8F187C5CF60836D9C0331AA8174BD0C742F9C0A94C34C4AE8BE9C31446167B9FCC774E325F08139D201CC51A0201D75305D1698CFB353A0EF7CDF9F7D0409894834351F4825B2F4F146F9BBABBA178D4197D501FF733F5C7C1247E204061F88B4FEDD127DA3B3464932CC945634DF480DE9D43F27EA529517A5C11C7E327EC263DC23727480FB812AEBF085DEEA8EF3DF96E7EE4C09FBCECFC88261ED9AF7CFC8CE8213E5BD0954ADD99D609A7F69464943B548BAAF4EA2371BE85681157E856212B7F5A2F68D1A54ACA3AF7B70A43DF7212A9C463A3E2ED96577A4B6CA3F955A714CD97062C058FE704E0E360F2A579399B5D29EAAB05CD172280F2F3C332EE1FE4D50AEBD258AEC2974601EBC9D3BCF82B5376E48F64835DCCB0B1B2D2E3DA350A2D64AB960A6FCFEE265385EE54AB6854627C508EF798C61E1EB96BA02D842C8730351A39C47202E4EAE8481AAC19CC620DF069E4271B1C6012C7211D7DE8CC9F1FC3A832F0A9A4B7D3A6A73E7C2C1C42EB8BAFF00EE765A2EA8B241A16A732E35250D1CC94FC53B4A04DBE4A014E4EBE3422C018062330CD77E2C70D62E81585387E823F58C5C7302C31FB1E0EB34F0B991231F20E33F57BA20843B24757A2421943F55E0A94DAA50573FB7C7BBF7BB97B7C7AD9ADBEDED620165C6D41E367180A0C7FD2821053A76A7C6AC3D260E1AD9611C46F33A153F5D79B4CB3D608CF65E6E22A546D0DE8028620ABEC69CA0BD45DBC4A821A1D3407FD0E61BFBB466AA3B500D54AE601FA113E361B945313817463503FB5A8A143C091ED555B23F9E72F7776458E7F9E26F9F36280794D35C0E21E0501ECBB84EA80ACC5D8A5A501EBEF76DD13E65E8A31B7C28ABC399796CF04BB7074C0D253981A24BD8B37A4B9EB368DB5ED29DD54D75EE38EF2F964EFADBEBFDC51E523E27FA7A31AD3F815A13043B883057A71304D4E1C84775F3B32A9D3402EA20D39F7B5EF461E69CBE337A1F16CBA08C51BF571F284BA0893B7E9A3A4F97211635D710AD32C47920C2F8B9134E96324A96E112169D01FCF33DDA5D79337AA388BB94412E51B4921A4F2F15A66B816FF35024557336883D4B08776883AB50B996D51F1B5B9F226AC7CAF2402D5ED9FEA518AEC938853B4EA2315596911A968ED80C433D32524DEFA69E82905C5D390937FF4F62366FDF03A75E727FAA2B2AB53DF4D28F9EE49A1632794340D2D62A42DFA0881CA9CA02B014B496611A9F4401F2FCB3595149C368D69A867328A7CC735DC1A6A90340CA17664BDCBC912C2658F53995E6EC211F3BC2294D8DE8137722A5736D1D2C30E521629DB92904573B71597F2B6F2B24B0FA7B5199E7D155178A33E8E9080AD0ADB3D18224315ADDDD8A1EFB7CFE40DD2FDE7705F909CC3747704D5C3EA342A6BB37B0454CDB468ED10C3782AB514C678AB3E92902B15A184667DAC221B2A4215ADD373AE7CE8A0124F3C8ED32198D85F73131C1FA454ED5795D33B55395A14CCF6B94AEA2ECB07E4A33B4B557B2E7EB20D7DA37C6B9FD84E927BD98671F1034F9BEBAC5D3E6D52B9A11C3AC95D3833F9E19374C8B4C80E7CDAEFA52827406917D380B5BF3B767CFAB33B86E09767718719906EED3A600B45877B449C3D0492B410C5BCBEBCBA9EADFE19512CDD6EF93C374DE66168BB15C76615D74DCA6FEE0CD73D9C58D5AD45341DABA0A41B1EC91C83EE77907744AD37447F07DBDCDF8B585DEF700C022ADDD3188424DCC5E8A31CE926C620510A3722C8A324D6B6C4C61F4BF35FC9A01B63FBB7977CDC85F148C14A6F8C4BE3DFCD73F7BFE9D1C34A4E79C162141B29DFA9D0D57A3AAA4EE7BD2E620C628F7CD9A20F9BE5AB16ED18FD2E5AF460D169EE388CC79F4D2FFE6C06F1273D723A017782A1C4A9B8ED3048A052D1F320A40136D6F966420F5A9FEA66C028C4562F030C7BA9D505FF833095A2FE3EECAD29E9FF240C964AF3FB2C5029CCEFABA5A1825478E31396E4F7B0BF6155F1A3859393D9875CEC3E084C29681F842617AD9FC0330F2A551E5A99CCABD43AD7221B036A18A72857ACAFC850A76A3A079AB23656BB56FB5C95B06AF1D679EAB0A72090462DC3AFBBC6FA9C242A8A4FA7AFA09E8A3C0DB5069FB03E5AADB5AB49414947900D95CFE9592D6CB45E7D78CF695C1CB52CBA6AC2CEC5D36516B6944ED7CD2854A20EAFAEAE9AA44BE9756DE5751570654DEB2445D94A696D6365ADC4BF521AE993975C775B689D25FCCAAAA9BB2F5A3642B50A6B944269353705BE56F89FD5C0D787CEA18088D36D045B252FCBFB6CC9DECF9DBD2451DE45DA61DC63866C70C12BCA9C3DB2183CB680D3C9D5D89F901B41975BEF15DB5BF218B12062B064ECBDBAA5F28F386834CD9F548397655E3C260761E1299600623AB004FC48FE1C39AECDE5BEABD82BD740C4D128DB9EC6EF92C5DBD4C391233DF8441328531F0FA2CFD80B5C000B1FC90EBDE33EB20179BFE203B28E798AB11EA4FD4594D5BED838E84091176618C578F8091CB6BD8FEFFF0F9704D34A60500000 , N'6.2.0-61023')
