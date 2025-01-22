using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003F4 RID: 1012
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectFavoriteRequest : IMessage<ObjectFavoriteRequest>, IMessage, IEquatable<ObjectFavoriteRequest>, IDeepCloneable<ObjectFavoriteRequest>, IBufferMessage
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x001D2F24 File Offset: 0x001D1124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectFavoriteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x001D2F34 File Offset: 0x001D1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x001D2F44 File Offset: 0x001D1144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x001D2F54 File Offset: 0x001D1154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteRequest()
		{
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x001D2F64 File Offset: 0x001D1164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteRequest(ObjectFavoriteRequest other)
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x001D2F74 File Offset: 0x001D1174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteRequest Clone()
		{
			return null;
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x001D2F84 File Offset: 0x001D1184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectFavoriteRequest.Types.ObjectFavorite> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x001D2F94 File Offset: 0x001D1194
		// (set) Token: 0x06002FBF RID: 12223 RVA: 0x001D2FA4 File Offset: 0x001D11A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Favorite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x001D2FB4 File Offset: 0x001D11B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x001D2FC4 File Offset: 0x001D11C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectFavoriteRequest other)
		{
			return true;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x001D2FD4 File Offset: 0x001D11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x001D2FE4 File Offset: 0x001D11E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x001D2FF4 File Offset: 0x001D11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x001D3004 File Offset: 0x001D1204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x001D3014 File Offset: 0x001D1214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x001D3024 File Offset: 0x001D1224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectFavoriteRequest other)
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x001D3034 File Offset: 0x001D1234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x001D3044 File Offset: 0x001D1244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x001D3054 File Offset: 0x001D1254
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectFavoriteRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					ObjectFavoriteRequest._repeated_objects_codec = FieldCodec.ForMessage<ObjectFavoriteRequest.Types.ObjectFavorite>(10U, cEr5eQni46fENBbNYi1E.XVInXhlssT(cEr5eQni46fENBbNYi1E.RHgnijuRXDn));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					ObjectFavoriteRequest._parser = new MessageParser<ObjectFavoriteRequest>(() => null);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x001D315C File Offset: 0x001D135C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool elsZCoO0TYwVGYlk1Vd1()
		{
			return true;
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x001D3164 File Offset: 0x001D1364
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectFavoriteRequest IpDwiiO0po6IH6Oe1wMg()
		{
			return null;
		}

		// Token: 0x040010C6 RID: 4294
		private static readonly MessageParser<ObjectFavoriteRequest> _parser;

		// Token: 0x040010C7 RID: 4295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010C8 RID: 4296
		public const int ObjectsFieldNumber = 1;

		// Token: 0x040010C9 RID: 4297
		private static readonly FieldCodec<ObjectFavoriteRequest.Types.ObjectFavorite> _repeated_objects_codec;

		// Token: 0x040010CA RID: 4298
		private readonly RepeatedField<ObjectFavoriteRequest.Types.ObjectFavorite> objects_;

		// Token: 0x040010CB RID: 4299
		public const int FavoriteFieldNumber = 2;

		// Token: 0x040010CC RID: 4300
		private bool favorite_;

		// Token: 0x040010CD RID: 4301
		internal static ObjectFavoriteRequest vNi7j7O07RHk9YJgeLUk;

		// Token: 0x020003F5 RID: 1013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002FCD RID: 12237 RVA: 0x002BC1E4 File Offset: 0x002BA3E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020003F6 RID: 1014
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectFavorite : IMessage<ObjectFavoriteRequest.Types.ObjectFavorite>, IMessage, IEquatable<ObjectFavoriteRequest.Types.ObjectFavorite>, IDeepCloneable<ObjectFavoriteRequest.Types.ObjectFavorite>, IBufferMessage
			{
				// Token: 0x1700088E RID: 2190
				// (get) Token: 0x06002FCE RID: 12238 RVA: 0x002FBD60 File Offset: 0x002F9F60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectFavoriteRequest.Types.ObjectFavorite> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700088F RID: 2191
				// (get) Token: 0x06002FCF RID: 12239 RVA: 0x002FBD70 File Offset: 0x002F9F70
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000890 RID: 2192
				// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x002FBD80 File Offset: 0x002F9F80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06002FD1 RID: 12241 RVA: 0x002FBD90 File Offset: 0x002F9F90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectFavorite()
				{
				}

				// Token: 0x06002FD2 RID: 12242 RVA: 0x002FBDA0 File Offset: 0x002F9FA0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectFavorite(ObjectFavoriteRequest.Types.ObjectFavorite other)
				{
				}

				// Token: 0x06002FD3 RID: 12243 RVA: 0x002FBDB0 File Offset: 0x002F9FB0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectFavoriteRequest.Types.ObjectFavorite Clone()
				{
					return null;
				}

				// Token: 0x17000891 RID: 2193
				// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x002FBDC0 File Offset: 0x002F9FC0
				// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x002FBDD0 File Offset: 0x002F9FD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ObjectUid
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000892 RID: 2194
				// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x002FBDE0 File Offset: 0x002F9FE0
				// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x002FBDF0 File Offset: 0x002F9FF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Position
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06002FD8 RID: 12248 RVA: 0x002FBE00 File Offset: 0x002FA000
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002FD9 RID: 12249 RVA: 0x002FBE10 File Offset: 0x002FA010
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectFavoriteRequest.Types.ObjectFavorite other)
				{
					return true;
				}

				// Token: 0x06002FDA RID: 12250 RVA: 0x002FBE20 File Offset: 0x002FA020
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002FDB RID: 12251 RVA: 0x002FBE30 File Offset: 0x002FA030
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002FDC RID: 12252 RVA: 0x002FBE40 File Offset: 0x002FA040
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002FDD RID: 12253 RVA: 0x002FBE50 File Offset: 0x002FA050
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002FDE RID: 12254 RVA: 0x002FBE60 File Offset: 0x002FA060
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002FDF RID: 12255 RVA: 0x002FBE70 File Offset: 0x002FA070
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectFavoriteRequest.Types.ObjectFavorite other)
				{
				}

				// Token: 0x06002FE0 RID: 12256 RVA: 0x002FBE80 File Offset: 0x002FA080
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06002FE1 RID: 12257 RVA: 0x002FBE90 File Offset: 0x002FA090
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06002FE2 RID: 12258 RVA: 0x002FBEA0 File Offset: 0x002FA0A0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectFavorite()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							ObjectFavoriteRequest.Types.ObjectFavorite._parser = new MessageParser<ObjectFavoriteRequest.Types.ObjectFavorite>(() => null);
							num2 = 2;
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06002FE3 RID: 12259 RVA: 0x002FBF84 File Offset: 0x002FA184
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool iAjOsxGYtO44TZbtbann()
				{
					return true;
				}

				// Token: 0x06002FE4 RID: 12260 RVA: 0x002FBF8C File Offset: 0x002FA18C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectFavoriteRequest.Types.ObjectFavorite SPj8hqGYwb7yoY9PGhNf()
				{
					return null;
				}

				// Token: 0x040010CE RID: 4302
				private static readonly MessageParser<ObjectFavoriteRequest.Types.ObjectFavorite> _parser;

				// Token: 0x040010CF RID: 4303
				private UnknownFieldSet _unknownFields;

				// Token: 0x040010D0 RID: 4304
				public const int ObjectUidFieldNumber = 1;

				// Token: 0x040010D1 RID: 4305
				private int objectUid_;

				// Token: 0x040010D2 RID: 4306
				public const int PositionFieldNumber = 2;

				// Token: 0x040010D3 RID: 4307
				private int position_;

				// Token: 0x040010D4 RID: 4308
				internal static ObjectFavoriteRequest.Types.ObjectFavorite YBZNOiGYDLaOrdvFO6bv;
			}
		}
	}
}
