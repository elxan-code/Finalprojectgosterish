USE [GoBazarDB]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (4, N'fa-solid fa-tablet', N'Tablet')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (5, N'fa-solid fa-mobile', N'Smartphones')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (6, N'fa-solid fa-tv', N'TV & Video')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (7, N'fa-solid fa-camera', N'Cameras & Photos')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (8, N'fa-solid fa-clock', N'Smart watch')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (9, N'fa-solid fa-desktop', N'Notebooks')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (10, N'fa-solid fa-headset', N'Headsets')
INSERT [dbo].[Categories] ([Id], [Icon], [Name]) VALUES (11, N'fa-solid fa-gamepad', N'Console Game')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategories] ON 

INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (9, N'c158fe76-56dc-4a3d-8507-40d9d785d572-applesmartt.png', N'Tablet', N'Apple', 4)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (12, N'05ac7ac8-1291-499b-b7c2-5312b8ce852c-logosamsung.jpg', NULL, N'Samsung', 4)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (13, N'a2872c40-eba1-4d20-9855-6a880bf03864-huaveylogo3.jpg', NULL, N'Huawei', 4)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (14, N'e82549e6-80e2-4cf7-959b-69da1f362d46-lenovologo-1.png', NULL, N'Lenovo', 4)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (15, N'01ea1582-49cc-4c05-971a-572b2ed3d850-tcl-logo.png', NULL, N'TCL', 4)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (16, N'e6a58daa-85ae-47f3-9f76-f977b8829372-applesmartt.png', N'SmartPhones', N'Apple', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (17, N'4fde754c-ecb7-4cab-ac2b-0622b302e8da-xiomismorort.jpg', NULL, N'Xiaomi', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (18, N'9afc3c25-2fcd-4998-9c9d-7cdcb4d08ba1-logosamsung.jpg', NULL, N'Samsung', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (19, N'186c9d32-b6c3-492b-851b-f534953a24d5-huaveylogo3.jpg', NULL, N'Huawei', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (20, N'0cdcb978-af08-4c88-b69d-4100239501bb-Oneplus.jpg', NULL, N'OnePlus', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (21, N'3ae3313e-74a3-43c9-8417-6b1b3519620f-nokialogo.jpg', NULL, N'Nokia', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (22, N'ec7fbd02-eeda-4fb9-8b2e-cb1fb737f6ab-Oppologo.jpg', NULL, N'OPPO', 5)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (23, N'5837c93a-3788-4117-b138-46a837135212-LG-Life-is-Good-1.jpg', N'TV & Video	', N'LG', 6)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (24, N'567e8054-83cc-4feb-888d-d77e1e215589-sony-logo.jpg', NULL, N'Sony', 6)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (25, N'ebd3e656-e405-4968-abb6-14b47626d5e5-hisense-logo.png', NULL, N'Hisense', 6)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (26, N'4e61d6cb-663b-4968-987e-e0e6959eb8e5-logosamsung.jpg', NULL, N'Samsung', 6)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (27, N'5fb944a5-dc2a-4da0-a6fe-474facae40e5-tcl-logo.png', NULL, N'TCL', 6)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (28, N'8c8afe6e-04de-4ea2-b6bf-9ce8ad43c7bd-canon-logo.png', N' Cameras & Photos', N'Canon', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (29, N'4c651593-57db-480e-b747-d923283efdbd-Nikon.png', NULL, N'Nikon', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (30, N'7623414d-b9e1-4fda-a0e8-419bbaa7a358-sony-logo.jpg', NULL, N'Sony', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (31, N'30e53503-17f5-4a3e-96f9-c8a42b89e518-fujifilm-logo.png', NULL, N'FujiFilm', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (32, N'a0b9052b-1cb2-40a2-821e-fbe2e6847f4a-panasonic-logo.jpg', NULL, N'Ponosonic', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (33, N'8358be64-bc6d-47c7-a285-829a12d83e98-go-pro-logo.png', NULL, N'Go Pro', 7)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (34, N'ea74d84f-3f2c-48b6-91c8-9b5ecac9d698-applesmartt.png', N'Smart watch', N'Apple', 8)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (35, N'ba5ff85b-9cc5-4a9d-9ced-0c258fa55b8a-xiomismorort.jpg', NULL, N'Xiaomi', 8)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (36, N'701e2cdd-a351-4cc6-9c8e-2e9a6fab6783-logosamsung.jpg', NULL, N'Samsung', 8)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (37, N'20fd2949-ae1a-4f80-8f07-22d617905542-huaveylogo3.jpg', NULL, N'Huawei', 8)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (38, N'6559045a-2970-493f-a6f1-c6d0fc2e2a46-applesmartt.png', N'HeadSet', N'Apple', 10)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (39, N'4000bc85-ced5-4c9d-b79c-1bfb68b12e87-huaveylogo3.jpg', NULL, N'Huawei', 10)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (40, N'316dcf07-ee5d-412d-b6d3-53c0aa60102c-xiomismorort.jpg', NULL, N'Xiaomi', 10)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (41, N'beab92a7-d111-474f-9787-bd6adff125d7-dr.dre-logo.png', NULL, N'Dr Dre', 10)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (42, N'075dc1e6-1817-4458-bf71-c56dcc4720f3-jbl-logo.jpg', NULL, N'JBL', 10)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (43, N'bd78e005-e861-4a5d-ac6e-ba96a6438cbc-playstationss.jpg', N'Console Game', N'Playstation', 11)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (44, N'1b4742c2-0bf3-4f0a-b953-4b4569261cd9-xbox.jpg', NULL, N'Xbox', 11)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (45, N'3d7004f0-20c1-4b3e-8777-633aa87909c0-NIntendoi.jpg', NULL, N'Nintendo', 11)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (46, N'b641233c-8912-4c87-a48d-0d1fcb88393f-applesmartt.png', N'Notebooks', N'Apple', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (47, N'94ca6096-938a-4c37-a4bb-2418ef945e35-acer-logo.jpg', NULL, N'Acer', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (48, N'24449975-59bd-43f5-b5c2-a4a40d0e5e23-asus-logo.jpg', NULL, N'Asus', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (49, N'7a2aefb2-e22d-4205-957e-604e141124c0-fijutsu-logo.jpg', NULL, N'Fijutsu', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (50, N'251a2d3b-b910-41eb-b3b4-f720343b4e92-dell-logo.jpg', NULL, N'Dell', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (51, N'23e28ee3-2469-43ab-9094-a01035a0431d-hp-logo.jpg', NULL, N'HP', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (52, N'0131bcb6-98bb-4ff6-b064-dec052019fae-lenovologo-1.png', NULL, N'Lenovo', 9)
INSERT [dbo].[SubCategories] ([Id], [Image], [Title], [Name], [CategoryId]) VALUES (53, N'ed2f82ba-df5a-49a1-a3d4-2329ca0fb53a-msi-logo.png', NULL, N'MSI', 9)
SET IDENTITY_INSERT [dbo].[SubCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (24, N'Smartphones>>Apple', N'Apple', N'Iphone 13', 150, N'Green', CAST(2529.99 AS Decimal(18, 2)), NULL, NULL, NULL, 5, 16)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (25, NULL, N'PlayStation', N'PlayStation 5', 200, N'White', CAST(1199.99 AS Decimal(18, 2)), CAST(999.99 AS Decimal(18, 2)), CAST(N'2022-05-28T00:00:00.0000000' AS DateTime2), N'30%', 11, 43)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (26, NULL, N'Samsung', N'Galaxy Tab S8+ 5G 128 GB (SM-X806)', 100, N'Pink Gold', CAST(2349.99 AS Decimal(18, 2)), NULL, NULL, NULL, 4, 12)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (27, NULL, N'LG', N'LED 55UQ76003LD', 90, N'Black', CAST(1899.99 AS Decimal(18, 2)), CAST(1649.99 AS Decimal(18, 2)), CAST(N'2022-05-29T00:00:00.0000000' AS DateTime2), N'20%', 6, 23)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (28, NULL, N'MSI ', N'KATANA GF66 12UE i7-12700H/8Гб/1TBSSD/RTX3060', 150, N'Black', CAST(4899.99 AS Decimal(18, 2)), CAST(4399.99 AS Decimal(18, 2)), CAST(N'2022-05-29T00:00:00.0000000' AS DateTime2), N'25%', 9, 53)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (29, NULL, N'Apple', N'Watch 6 40 Mm', 200, N'Red', CAST(1099.99 AS Decimal(18, 2)), NULL, NULL, NULL, 8, 34)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (30, NULL, N'Canon', N'EOS 850D 18-55', 300, N'Black', CAST(2169.99 AS Decimal(18, 2)), NULL, NULL, NULL, 7, 28)
INSERT [dbo].[Products] ([Id], [Title], [Model], [Brand], [Stock], [Color], [Price], [DiscountPrice], [DiscountDate], [Discountfaiz], [CategoryId], [SubCategoryId]) VALUES (31, NULL, N'Apple', N'Ipad', 600, N'Gray', CAST(1849.99 AS Decimal(18, 2)), CAST(1649.99 AS Decimal(18, 2)), CAST(N'2022-05-29T00:00:00.0000000' AS DateTime2), N'30%', 4, 9)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductOfProducts] ON 

INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (24, 24)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (25, 24)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (26, 25)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (27, 25)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (28, 26)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (29, 26)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (30, 27)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (31, 27)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (32, 28)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (33, 28)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (34, 29)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (35, 29)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (36, 30)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (37, 30)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (38, 31)
INSERT [dbo].[ProductOfProducts] ([Id], [ProductId]) VALUES (39, 31)
SET IDENTITY_INSERT [dbo].[ProductOfProducts] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'3036f664-9377-476f-9e07-31735f932631', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'tu201806145@code.edu.az', NULL, N'tu201806145@code.edu.az', NULL, 0, NULL, N'1f27eecd-6e77-4126-b64b-b2d1022dfb44', N'ff5b4b25-98a6-450f-97e2-9ebb5dc00e16', NULL, 0, 0, NULL, 0, 0, N'yeni yasamal')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'30a60e06-dd02-47d6-97c5-6b7380396e46', N'CustomUser', N'elxan seyidov', N'Seyidov', NULL, 0, N'tu201806274@code.edu.az', N'TU201806274@CODE.EDU.AZ', N'tu201806274@code.edu.az', N'TU201806274@CODE.EDU.AZ', 0, N'AQAAAAEAACcQAAAAEEQZoTuNBu+6cf/cOlSa+WgtGsW+2pjSS7sUNKWlmY99Jtn9bC2QADJ6FaKetLTWag==', N'MSU3UGF4PMCQZA3QI2MHXPFMIGNYPOKK', N'36c60c4e-812f-4ae0-b076-4d7f5fb9c347', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elxan789123@gmail.com', NULL, N'elxan789123@gmail.com', NULL, 0, NULL, N'94b5a3fd-9253-4e28-abaf-bac9108ecedd', N'c739ca8c-f3aa-431b-aece-c49c6695eb29', NULL, 0, 0, NULL, 0, 0, N'yeni yasamal')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'40e5ccc1-8a21-421c-b603-f27132cce2f4', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elxan1234@gmail.com', N'ELXAN1234@GMAIL.COM', N'elxan1234@gmail.com', N'ELXAN1234@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIcPbE/EpM7ZqvNXD/DwOo+8v8hHYE46KrKcVjx9SVf/em4365636oszuijyBQsMaA==', N'F6LINPR62KHEQHU76YCSKJB4DC6BIBNY', N'4cbb183a-9c06-4a3a-8bdc-b36f3374629d', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'59c3d40f-fa4e-40da-9516-dd7db3d1e68a', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elxan789456@gmail.com', NULL, N'elxan789456@gmail.com', NULL, 0, NULL, N'eb604e8f-cd68-49d1-b94c-4dcb9dc0ad6e', N'f5a56cc2-2d28-4439-afd4-9209b96a9e71', NULL, 0, 0, NULL, 0, 0, N'yeni yasamal')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'6b75aef9-7717-4501-8938-a19b60bee79e', N'CustomUser', N'elxan seyidov', N'Seyidov', NULL, 0, N'elkhan.code@gmail.com', N'ELKHAN.CODE@GMAIL.COM', N'elkhan.code@gmail.com', N'ELKHAN.CODE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBFaCHoSSPyaFXNGm6FDvoDjMG5cpl6dsiIUBoXDhhwa9M1h/UlQ5YM6BKUn7C68jg==', N'5A35DI23U24GJJM6W7DTZ6QO6SQEV32J', N'524d9904-c449-4693-a64a-8df1635f598b', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'7162b21e-3c2b-4b3f-bea1-86c6002d7b4e', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elxan77799@gmail.com', N'ELXAN77799@GMAIL.COM', N'elxan77799@gmail.com', N'ELXAN77799@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJHCp4reiqfYoppYN9KTPAxnvRN7ne2Wh7cVxk1IIzsKBb4zmF8BHM7Ox/HYJ5KtAw==', N'L4P3ZDA2UJCTZ2ROIUQYERVAEUFGKFK7', N'fac4e476-bdb6-46ef-804f-d81702b83655', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'785f3119-f6f8-4f06-857f-0e372e405ee4', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elxan789123@gmail.com', N'ELXAN789123@GMAIL.COM', N'elxan789123@gmail.com', N'ELXAN789123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFAzU0BDtjlGH8ycodf7GeOIrVIjFbRnw6T2WDGBPdH7S66Om3rP4CCe7iDos04OsQ==', N'VHL3IE22VZBM3N62L4VO6BR55E4ZHA65', N'bb2a5332-72cc-4194-bec5-4ac49e340c06', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'88b8c11c-562a-434c-8968-650d70197b5f', N'CustomUser', N'Elxan', N'Seyidov', NULL, 0, N'elxan123@gmail.com', N'ELXAN123@GMAIL.COM', N'elxan123@gmail.com', N'ELXAN123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEK/9KAK95C5n8LC6KomA7s/MuyiiskHypi9OMpYHnAG6DsqIxxSuGHBevHrjBWl8CA==', N'4XX437UM3QLN22NPMFZOYJ6WIKDASBI3', N'2074b93f-0ba5-4433-879e-5738964964af', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'CustomUser', N'Admin', N'SuperAdmin', NULL, 1, N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENCxnPaUUyA43lhf5WSQ00jYO9suFxwqhJwxKwN/qnUWvwr5ZuwHDEIwkH0LxA3+XA==', N'Y72XEPTSVOQQTMY3N6Z4CNGJB7I4QVP7', N'e2530e98-3f65-4b1f-95d7-0d247825fdec', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'9f1b79f2-4db2-4321-988f-9ff847e5c731', N'CustomUser', N'Emil', N'Memmedov', NULL, 0, N'emilmmmdov77@gmail.com', N'EMILMMMDOV77@GMAIL.COM', N'emilmmmdov77@gmail.com', N'EMILMMMDOV77@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJPrylbXRa1cW9R9hPtdLK4UHbPZYomAFUrOZMtW7s+/6ZWyLcEuWSRTtAI8WQBylg==', N'5LHXUMDRETG6CTPDDH74YCS3THZSZS2M', N'e82d61e8-c863-4896-9d6d-f8e7ef0a23b8', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'b9adb792-d638-4415-896d-aaf0faab788c', N'CustomUser', N'elxan seyidov', N'seyidov', NULL, 0, N'elxans318@gmail.com', N'ELXANS318@GMAIL.COM', N'elxans318@gmail.com', N'ELXANS318@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGbinbp1sTRb70xO+3yn8OziZR8Oa2AE7p/YAY8crYi+p70xp44J36TeIz7EENuAYQ==', N'KYZA4IAVJ5JMWFNRCAFWNTLPZ7KXWKJX', N'f2a0a916-4379-4252-bbb4-bbc4c13018b1', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Phone], [IsAdmin], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address]) VALUES (N'cf2f20c6-4bdc-4ba8-8854-e1837b1ddc99', N'CustomUser', N'elxan', N'seyidov', NULL, 0, N'elkhan.code@gmail.com', NULL, N'elkhan.code@gmail.com', NULL, 0, NULL, N'ae8d376b-582b-4922-9b56-3d36a8bbd00d', N'5e422cef-c7e2-48d4-b3a2-dae057f67071', NULL, 0, 0, NULL, 0, 0, N'yeni yasamal')
GO
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (1, N'00000000001', NULL, N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-04-30T17:10:09.0630480' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (2, N'00000000002', NULL, N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-04-30T17:10:57.0977264' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (3, N'00000000003', NULL, N'8b0b7538-8b71-4af2-9c64-3709144afd65', CAST(N'2022-04-30T17:15:00.0637525' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (4, N'00000000004', CAST(10.00 AS Decimal(18, 2)), N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-04-30T17:35:44.6088450' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (5, N'00000000005', CAST(10.00 AS Decimal(18, 2)), N'59c3d40f-fa4e-40da-9516-dd7db3d1e68a', CAST(N'2022-04-30T18:00:33.7352232' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (6, N'00000000006', CAST(10.00 AS Decimal(18, 2)), N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-05-01T17:00:35.9624870' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (7, N'00000000007', CAST(10.00 AS Decimal(18, 2)), N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-05-01T21:20:55.7490316' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (8, N'00000000008', CAST(10.00 AS Decimal(18, 2)), N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-05-01T21:32:33.5921339' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (9, N'00000000009', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:51:16.3635532' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (10, N'00000000010', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:51:53.7146647' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (11, N'00000000011', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:52:01.2169476' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (12, N'00000000012', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:53:36.6318579' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (13, N'00000000013', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:53:47.2352242' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (14, N'00000000014', CAST(10.00 AS Decimal(18, 2)), N'40b80f6f-ac17-4e29-9ecf-d432dc76fd2f', CAST(N'2022-05-04T06:58:32.7124409' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (15, N'00000000015', CAST(10.00 AS Decimal(18, 2)), N'7162b21e-3c2b-4b3f-bea1-86c6002d7b4e', CAST(N'2022-05-04T07:04:03.5234494' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (16, N'00000000016', CAST(10.00 AS Decimal(18, 2)), N'b9adb792-d638-4415-896d-aaf0faab788c', CAST(N'2022-05-04T07:08:57.1821960' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (17, N'00000000017', CAST(10.00 AS Decimal(18, 2)), N'b9adb792-d638-4415-896d-aaf0faab788c', CAST(N'2022-05-04T07:10:27.0577703' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (18, N'00000000018', CAST(10.00 AS Decimal(18, 2)), N'b9adb792-d638-4415-896d-aaf0faab788c', CAST(N'2022-05-04T07:14:03.3468303' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (19, N'00000000019', CAST(10.00 AS Decimal(18, 2)), N'b9adb792-d638-4415-896d-aaf0faab788c', CAST(N'2022-05-04T07:15:49.8978648' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (20, N'00000000020', CAST(10.00 AS Decimal(18, 2)), N'b9adb792-d638-4415-896d-aaf0faab788c', CAST(N'2022-05-04T07:16:28.0058483' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (21, N'00000000021', CAST(10.00 AS Decimal(18, 2)), N'cf2f20c6-4bdc-4ba8-8854-e1837b1ddc99', CAST(N'2022-05-04T07:23:11.7906990' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (22, N'00000000022', CAST(10.00 AS Decimal(18, 2)), N'cf2f20c6-4bdc-4ba8-8854-e1837b1ddc99', CAST(N'2022-05-04T07:23:12.1751669' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (23, N'00000000023', CAST(10.00 AS Decimal(18, 2)), N'3036f664-9377-476f-9e07-31735f932631', CAST(N'2022-05-04T17:39:27.6609637' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (24, N'00000000024', CAST(10.00 AS Decimal(18, 2)), N'30a60e06-dd02-47d6-97c5-6b7380396e46', CAST(N'2022-05-04T17:39:49.4675589' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (25, N'00000000025', NULL, N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-05-04T18:59:31.0964981' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (26, N'00000000026', CAST(10.00 AS Decimal(18, 2)), N'88b8c11c-562a-434c-8968-650d70197b5f', CAST(N'2022-05-04T19:00:25.3563712' AS DateTime2))
INSERT [dbo].[Sales] ([Id], [No], [Shipping], [CustomerId], [CreatedDate]) VALUES (27, N'00000000027', NULL, N'9f1b79f2-4db2-4321-988f-9ff847e5c731', CAST(N'2022-05-22T04:18:17.7178657' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO
SET IDENTITY_INSERT [dbo].[SubFeatures] ON 

INSERT [dbo].[SubFeatures] ([Id], [Feature], [CategoryId]) VALUES (1, N'Ram', 4)
INSERT [dbo].[SubFeatures] ([Id], [Feature], [CategoryId]) VALUES (2, N'Color', 5)
INSERT [dbo].[SubFeatures] ([Id], [Feature], [CategoryId]) VALUES (3, N'sajhbhj', 4)
SET IDENTITY_INSERT [dbo].[SubFeatures] OFF
GO
SET IDENTITY_INSERT [dbo].[Chats] ON 

INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (4, N'salam', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (5, N'sa', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (6, N'salam', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'40e5ccc1-8a21-421c-b603-f27132cce2f4', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (7, N'obaaaa', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'40e5ccc1-8a21-421c-b603-f27132cce2f4')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (8, N'naw brat', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'40e5ccc1-8a21-421c-b603-f27132cce2f4')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (9, N'''/', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (10, N';''', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (11, N'salam', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (12, N'salam', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (13, N'salam', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'9f1b79f2-4db2-4321-988f-9ff847e5c731', N'8b0b7538-8b71-4af2-9c64-3709144afd65')
INSERT [dbo].[Chats] ([Id], [Text], [CreatedDate], [SenderId], [RecieverId]) VALUES (14, N'salam go bazar platformasina xosh gelmisiniz', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'8b0b7538-8b71-4af2-9c64-3709144afd65', N'9f1b79f2-4db2-4321-988f-9ff847e5c731')
SET IDENTITY_INSERT [dbo].[Chats] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductToProducts] ON 

INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (28, 24)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (29, 24)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (30, 25)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (31, 25)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (32, 26)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (33, 26)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (34, 27)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (35, 27)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (36, 28)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (37, 28)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (38, 29)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (39, 29)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (40, 30)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (41, 30)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (42, 31)
INSERT [dbo].[ProductToProducts] ([Id], [ProductId]) VALUES (43, 31)
SET IDENTITY_INSERT [dbo].[ProductToProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (28, N'e1c9b04c-641d-4cc5-9396-805c8f3a4555-image1.png', 28)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (29, N'84bc3411-5def-4ff8-ae6f-0226ee30ca28-image1.png', 29)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (30, N'0a926a71-8cc2-4742-a703-3c49de01123b-image1.png', 30)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (31, N'90dcd34c-4f10-45e5-8d7d-1b1e519ad9bd-image1.png', 31)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (32, N'a174e654-faa5-4fb0-9488-6e4c56c76c16-image1.png', 32)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (33, N'c4753dfe-50a0-44ff-871d-32cb44d28756-image1.png', 33)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (34, N'fc4bed5a-c8f0-448a-8933-e1c09f948366-image1.png', 34)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (35, N'1a9df8b0-1c9b-4525-b7d0-08baf517c9a6-image1.png', 35)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (36, N'3b01f2d8-d2d2-4e79-b7fa-63a68934cfb5-image1.png', 36)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (37, N'c98a460b-8916-454c-8a2a-0f5e25a9144f-image1.png', 37)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (38, N'6997905c-bd73-4f23-83bb-486ccdbae877-image1.png', 38)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (39, N'2fc81ce2-437a-468d-809c-c4e67cb29a05-image1.png', 39)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (40, N'acb3f20b-26f0-4ce1-a1d1-0d3dce29628e-image1.png', 40)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (41, N'79bc84f1-9e89-4a9d-8078-0366b0d7b54b-image1.png', 41)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (42, N'02752c3b-a578-4240-914c-a0a72fbb3714-image1.png', 42)
INSERT [dbo].[ProductImages] ([Id], [Image], [ProductToProductId]) VALUES (43, N'3e963d7d-c66a-4fbb-807e-1dd2e50eee25-image1.png', 43)
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Advertisings] ON 

INSERT [dbo].[Advertisings] ([Id], [Image], [Link]) VALUES (1, N'0e173322-d630-496b-97eb-1df27dd607eb-tapaz.jpg', N'https://tap.az/')
SET IDENTITY_INSERT [dbo].[Advertisings] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Uptitle], [Title], [CreatedDate], [Image]) VALUES (1, N'What is MetaVerse?', N'A metaverse is a network of 3D virtual worlds focused on social connection. In futurism and science fiction, it is often described as a hypothetical iteration of the Internet as a single, universal virtual world that is facilitated by the use of virtual and augmented reality headsets.', CAST(N'2022-03-10T18:36:00.0000000' AS DateTime2), N'37568c47-824c-41f9-8550-4ca68699fa1b-s1.jfif')
INSERT [dbo].[Blogs] ([Id], [Uptitle], [Title], [CreatedDate], [Image]) VALUES (2, N'Gta VI comin in 2023-2024', N'On Friday February 4, Rockstar Games took to Twitter and their newswire to offer a community update its Grand Theft Auto series which included a long-awaited announcement about the development of Grand Theft Auto 6.  "With the unprecedented longevity of GTAV, we know many of you have been asking us about a new entry in the Grand Theft Auto series,” wrote Rockstar.  "With every new project we embark on, our goal is always to significantly move beyond what we have previously delivered — and we are pleased to confirm that active development for the next entry in the Grand Theft Auto series is well underway.  They added: "We look forward to sharing more as soon as we are ready, so please stay tuned to the Rockstar Newswire for official details.“On behalf of our entire team, we thank you all for your support and cannot wait to step into the future with you!”  The news of Grand Theft Auto 6’s development at last comes after the franchise’s third game, and first game under Rockstar North, celebrated its 20th anniversary on October 8 2021', CAST(N'2022-03-10T18:38:00.0000000' AS DateTime2), N'06a7247c-7af5-4870-bc5b-e8c7c674e655-GTA_6_Release_Rockstar_Games.jpg')
INSERT [dbo].[Blogs] ([Id], [Uptitle], [Title], [CreatedDate], [Image]) VALUES (3, N'Windows 11 have bugs?', N'Windows 11 is officially out, and early adopters have reported bugs and issues with the next generation of Windows.  While many of these issues should get sorted out pretty quickly by Microsoft, if you encounter one it doesn''t matter how soon a fix might come — you want to know what''s going wrong with your PC, and how to deal with it.  See our full Windows 11 review The best Windows laptops you can buy right now Windows 11 vs Windows 10: Here''s what''s new To help you solve your Windows 11 woes, we''ve pulled together this guide to the most common Windows 11 problems we''re seeing right now, and what (if anything) can be done about them.', CAST(N'2022-03-10T18:40:00.0000000' AS DateTime2), N'fe2e1e32-1c83-41e4-8897-02efe9da3a6d-eooagXPMSQVNwgpnEsZwZG.jpg')
INSERT [dbo].[Blogs] ([Id], [Uptitle], [Title], [CreatedDate], [Image]) VALUES (4, N'Xiaomi new smart Glasses', N'Xiaomi’s Smart Glasses are powered by a quad-core ARM processor and run on Android. They also use MicroLED imaging technology, which is known for having a higher brightness and longer lifespan than OLED. The company says the technology has a simpler structure that enabled it to create a compact display with individual pixels sized at 4μm. You won’t be able to view the images you take in color, though — Xiaomi says it opted to use a monochrome display solution “to allow sufficient light to pass through complicated optical structures.”   The company explains:  “The grating structure etched onto the inner surface of the lens allows light to be refracted in a unique way, directing it safely into the human eye. The refraction process involves bouncing light beams countless times, allowing the human eye to see a complete image, and greatly increasing usability while wearing. All this is done inside a single lens, instead of using complicated multiples lens systems, mirrors, or half mirrors as some other products do.”  Its smart glasses won’t be just a second screen for your phone, according to Xiaomi. It’s independently capable of many things, such as selecting the most important notifications to show you, including smart home alarms and messages from important contacts. The device’s navigation capability can display maps and directions in front of your eyes. It can also show you the number of whoever’s currently calling your phone, and you can take the call using the smart glasses’ built in mic and speakers.  That mic will be able to pick up speech, as well, which Xiaomi’s proprietary translating algorithm can translate in real time. The glasses’ translation feature also works’ on written text and text on photos captures through its camera. Unfortunately, the company has yet to announce a price or a launch date for the glasses, but we’ll keep you updated when it does.', CAST(N'2022-03-10T18:41:00.0000000' AS DateTime2), N'd1fecafc-db17-47e8-8121-3813312edf45-gsmarena_004.jpg')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[BrandsLogos] ON 

INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (1, N'bf737647-1739-4531-b5ed-1a938b2a12be-huaveylogo3.jpg', N'https://www.huawei.com/en/?ic_medium=direct&ic_source=surlent')
INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (2, N'707250e2-f4c9-476c-b59b-5ea3c3d4cb2c-applesmartt.png', N'https://www.apple.com/')
INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (3, N'36d7243e-16cc-4bf3-96ac-246d0e163792-playstationss.jpg', N'https://www.playstation.com/en-us/')
INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (4, N'3fb62857-e84d-4ccf-967e-c00fbc3821df-dr.dre-logo.png', N'https://www.beatsbydre.com/')
INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (5, N'5e34207e-f912-458b-873d-cd98a7a2845a-go-pro-logo.png', N'https://gopro.com/en/az/en')
INSERT [dbo].[BrandsLogos] ([Id], [Image], [Link]) VALUES (6, N'02841859-89f8-465c-a04b-0f3499a0ae09-logosamsung.jpg', N'https://www.samsung.com/')
SET IDENTITY_INSERT [dbo].[BrandsLogos] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Name], [Email], [Destiraction], [CreatedDate]) VALUES (7, N'Emil', N'emil123@gmail.com', N'Мы и наши партнеры используем такие технологии, как файлы cookie, и обрабатываем персональные данные, такие как IP-адрес или информацию браузера, для персонализации рекламы, которую вы видите. Это помогает нам показывать вам более релевантную рекламу и улучшает вашу работу в интернете. Мы также используем эти данные для измерения результатов или настройки содержания нашего веб-сайта. Поскольку мы ценим вашу конфиденциальность, мы просим вашего разрешения на использование этих технологий. Вы всегда можете изменить или отозвать свое согласие позже в разделе "Политика конфиденциальности".', CAST(N'2022-03-12T18:39:07.9692337' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[FlashDeal2s] ON 

INSERT [dbo].[FlashDeal2s] ([Id], [Link], [Title], [Uptitle], [Image]) VALUES (1, N'https://www.google.com/', N'Smart Headsets', N'Get Extra 15% Discount on', N'b75f64b0-fccc-405c-9d09-d6afd76e0fd3-bottombanner-01.jpg')
INSERT [dbo].[FlashDeal2s] ([Id], [Link], [Title], [Uptitle], [Image]) VALUES (2, N'https://www.google.com/', N'Get Extra $10', N'GLimited offer for Tablets', N'22620687-ddf2-4acd-ae63-24ea90cfbf20-bottombanner-02.jpg')
SET IDENTITY_INSERT [dbo].[FlashDeal2s] OFF
GO
SET IDENTITY_INSERT [dbo].[HomeImage1s] ON 

INSERT [dbo].[HomeImage1s] ([Id], [Image]) VALUES (1, N'bcfc093a-4cc9-4976-83cb-9b30ae7b5283-SubBanner-01.jpg')
SET IDENTITY_INSERT [dbo].[HomeImage1s] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Icon], [Title1], [Title2]) VALUES (1, N'fa-solid fa-bus', N'Easy to buy & return', N'Single click to buy & return')
INSERT [dbo].[Services] ([Id], [Icon], [Title1], [Title2]) VALUES (2, N'fa-solid fa-credit-card', N'Secure Payments', N'100% payment security')
INSERT [dbo].[Services] ([Id], [Icon], [Title1], [Title2]) VALUES (3, N'fa-solid fa-headphones', N'24x7 Support Available', N'support 24 hours a day')
INSERT [dbo].[Services] ([Id], [Icon], [Title1], [Title2]) VALUES (4, N'fa-solid fa-mobile', N'Shop with our App', N'Download app & get offers')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [Location], [Phone], [Email], [Poweredby], [StoreName], [Fax], [OpeninTime], [Comments], [Map]) VALUES (1, N'c606e2ce-cb56-4395-98ab-523f50033c3d-logo.png', N'Yeni Yasamal', N'910123456789', N'GoBazar@gmail.com', N'Powered By OpenCart Gobazar - Best Online Store © ', N'Gobazar - Best Online Store', N'0123456789', N'9:00 AM to 6:00 PM', N'Shop Laptop feature only the best laptop deals on  the market. By comparing laptop deals from   the  likes of PC World, Comet, Dixons, The Link and Carphone Warehouse', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2254.459504013009!2d49.79260524041466!3d40.39880218010924!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4030876df001a3db%3A0x6dd49887a78f0dd7!2sARMOSTORE!5e0!3m2!1sen!2s!4v1647015154066!5m2!1sen!2s" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (3, N'2be0032e-cb4c-4cc8-afd8-55326b5c1399-Main-banner-2-1903x520.jpg')
INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (4, N'f7ba5f7d-0746-4caa-9f05-ccf13481adec-Main-banner-1-1903x520.jpg')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (1, N'fa-brands fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (2, N'fa-brands fa-twitter', N'https://twitter.com/')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (3, N'fa-brands fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (4, N'fa-brands fa-instagram', N'https://www.instagram.com/')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[Specials] ON 

INSERT [dbo].[Specials] ([Id], [Image], [Model], [Brand], [Color], [Price], [Discount], [Discountfaiz]) VALUES (1, N'cf7fd8b0-e051-46a6-864f-6285e01f0a2a-xiaomi-xiaomi-poco-x3-pro-8gb-256gb.jpg', N'POCO X3', N'Xioami ', N'Blue', N'499$', N'599$', N'10%')
INSERT [dbo].[Specials] ([Id], [Image], [Model], [Brand], [Color], [Price], [Discount], [Discountfaiz]) VALUES (2, N'890eb5ef-ce3d-4883-b7d1-38c49ec6af5f-Apple-iPhone-Xs-600x600.jpg', N'Iphone XS', N'Apple', N'Gold', N'799$', N'999$', N'20%')
INSERT [dbo].[Specials] ([Id], [Image], [Model], [Brand], [Color], [Price], [Discount], [Discountfaiz]) VALUES (3, N'd9b42218-ad4a-4da0-adef-c8d5e5fc6d54-xbox-x-1.jpg', N'Series x', N'Xbox', N'Black', N'600$', N'999$', N'30%')
INSERT [dbo].[Specials] ([Id], [Image], [Model], [Brand], [Color], [Price], [Discount], [Discountfaiz]) VALUES (4, N'5ba5da1b-233e-4292-a56b-e1628a228de4-HP-250-G8-3Y666PA.jpg', NULL, N'HP', N'Hp 250 8Gb', N'1600$', N'800$', N'50%')
SET IDENTITY_INSERT [dbo].[Specials] OFF
GO
