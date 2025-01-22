using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E4F RID: 3663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceServersResponse : IMessage<AcquaintanceServersResponse>, IMessage, IEquatable<AcquaintanceServersResponse>, IDeepCloneable<AcquaintanceServersResponse>, IBufferMessage
	{
		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x002A1738 File Offset: 0x0029F938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AcquaintanceServersResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x002A1748 File Offset: 0x0029F948
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

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x002A1758 File Offset: 0x0029F958
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

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x002A1768 File Offset: 0x0029F968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersResponse()
		{
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x002A1778 File Offset: 0x0029F978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersResponse(AcquaintanceServersResponse other)
		{
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x002A1788 File Offset: 0x0029F988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersResponse Clone()
		{
			return null;
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600AFC6 RID: 44998 RVA: 0x002A1798 File Offset: 0x0029F998
		// (set) Token: 0x0600AFC7 RID: 44999 RVA: 0x002A17A8 File Offset: 0x0029F9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcquaintanceServersResponse.Types.Servers Servers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600AFC8 RID: 45000 RVA: 0x002A17B8 File Offset: 0x0029F9B8
		// (set) Token: 0x0600AFC9 RID: 45001 RVA: 0x002A17C8 File Offset: 0x0029F9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcquaintanceServersResponse.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600AFCA RID: 45002 RVA: 0x002A17D8 File Offset: 0x0029F9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcquaintanceServersResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AcquaintanceServersResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x002A17EC File Offset: 0x0029F9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x002A17FC File Offset: 0x0029F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x002A180C File Offset: 0x0029FA0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceServersResponse other)
		{
			return true;
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x002A181C File Offset: 0x0029FA1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x002A182C File Offset: 0x0029FA2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x002A183C File Offset: 0x0029FA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x002A184C File Offset: 0x0029FA4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x002A185C File Offset: 0x0029FA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x002A186C File Offset: 0x0029FA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceServersResponse other)
		{
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x002A187C File Offset: 0x0029FA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x002A188C File Offset: 0x0029FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x002A189C File Offset: 0x0029FA9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceServersResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AcquaintanceServersResponse._parser = new MessageParser<AcquaintanceServersResponse>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x002A1994 File Offset: 0x0029FB94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DAionUJv6qr921hKeiqA()
		{
			return true;
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x002A199C File Offset: 0x0029FB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceServersResponse z3vqIRJvLtyPvJWKqYyT()
		{
			return null;
		}

		// Token: 0x040040C8 RID: 16584
		private static readonly MessageParser<AcquaintanceServersResponse> _parser;

		// Token: 0x040040C9 RID: 16585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040CA RID: 16586
		public const int ServersFieldNumber = 1;

		// Token: 0x040040CB RID: 16587
		public const int ErrorFieldNumber = 2;

		// Token: 0x040040CC RID: 16588
		private object result_;

		// Token: 0x040040CD RID: 16589
		private AcquaintanceServersResponse.ResultOneofCase resultCase_;

		// Token: 0x040040CE RID: 16590
		internal static AcquaintanceServersResponse GTKg03JvyJIql7wUsvkd;

		// Token: 0x02000E50 RID: 3664
		public enum ResultOneofCase
		{
			// Token: 0x040040D0 RID: 16592
			None,
			// Token: 0x040040D1 RID: 16593
			Servers,
			// Token: 0x040040D2 RID: 16594
			Error
		}

		// Token: 0x02000E51 RID: 3665
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600AFD9 RID: 45017 RVA: 0x002F4B38 File Offset: 0x002F2D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E52 RID: 3666
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Servers : IMessage<AcquaintanceServersResponse.Types.Servers>, IMessage, IEquatable<AcquaintanceServersResponse.Types.Servers>, IDeepCloneable<AcquaintanceServersResponse.Types.Servers>, IBufferMessage
			{
				// Token: 0x1700209E RID: 8350
				// (get) Token: 0x0600AFDA RID: 45018 RVA: 0x00310160 File Offset: 0x0030E360
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<AcquaintanceServersResponse.Types.Servers> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700209F RID: 8351
				// (get) Token: 0x0600AFDB RID: 45019 RVA: 0x00310170 File Offset: 0x0030E370
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

				// Token: 0x170020A0 RID: 8352
				// (get) Token: 0x0600AFDC RID: 45020 RVA: 0x00310180 File Offset: 0x0030E380
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

				// Token: 0x0600AFDD RID: 45021 RVA: 0x00310190 File Offset: 0x0030E390
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Servers()
				{
				}

				// Token: 0x0600AFDE RID: 45022 RVA: 0x003101A0 File Offset: 0x0030E3A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Servers(AcquaintanceServersResponse.Types.Servers other)
				{
				}

				// Token: 0x0600AFDF RID: 45023 RVA: 0x003101B0 File Offset: 0x0030E3B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AcquaintanceServersResponse.Types.Servers Clone()
				{
					return null;
				}

				// Token: 0x170020A1 RID: 8353
				// (get) Token: 0x0600AFE0 RID: 45024 RVA: 0x003101C0 File Offset: 0x0030E3C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Servers_
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x0600AFE1 RID: 45025 RVA: 0x003101D0 File Offset: 0x0030E3D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AFE2 RID: 45026 RVA: 0x003101E0 File Offset: 0x0030E3E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AcquaintanceServersResponse.Types.Servers other)
				{
					return true;
				}

				// Token: 0x0600AFE3 RID: 45027 RVA: 0x003101F0 File Offset: 0x0030E3F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AFE4 RID: 45028 RVA: 0x00310200 File Offset: 0x0030E400
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AFE5 RID: 45029 RVA: 0x00310210 File Offset: 0x0030E410
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AFE6 RID: 45030 RVA: 0x00310220 File Offset: 0x0030E420
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AFE7 RID: 45031 RVA: 0x00310230 File Offset: 0x0030E430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AFE8 RID: 45032 RVA: 0x00310240 File Offset: 0x0030E440
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AcquaintanceServersResponse.Types.Servers other)
				{
				}

				// Token: 0x0600AFE9 RID: 45033 RVA: 0x00310250 File Offset: 0x0030E450
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AFEA RID: 45034 RVA: 0x00310260 File Offset: 0x0030E460
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AFEB RID: 45035 RVA: 0x00310270 File Offset: 0x0030E470
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Servers()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								AcquaintanceServersResponse.Types.Servers._parser = new MessageParser<AcquaintanceServersResponse.Types.Servers>(() => null);
								num2 = 5;
								continue;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								goto IL_39;
							case 5:
								AcquaintanceServersResponse.Types.Servers._repeated_servers_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							return;
						}
						IL_39:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 3;
					}
				}

				// Token: 0x0600AFEC RID: 45036 RVA: 0x00310374 File Offset: 0x0030E574
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool UfPv00GFe0UK7FcaCdsc()
				{
					return true;
				}

				// Token: 0x0600AFED RID: 45037 RVA: 0x0031037C File Offset: 0x0030E57C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AcquaintanceServersResponse.Types.Servers fIwTJcGF3vEOUi2o9mQl()
				{
					return null;
				}

				// Token: 0x040040D3 RID: 16595
				private static readonly MessageParser<AcquaintanceServersResponse.Types.Servers> _parser;

				// Token: 0x040040D4 RID: 16596
				private UnknownFieldSet _unknownFields;

				// Token: 0x040040D5 RID: 16597
				public const int Servers_FieldNumber = 1;

				// Token: 0x040040D6 RID: 16598
				private static readonly FieldCodec<int> _repeated_servers_codec;

				// Token: 0x040040D7 RID: 16599
				private readonly RepeatedField<int> servers_;

				// Token: 0x040040D8 RID: 16600
				private static AcquaintanceServersResponse.Types.Servers TY9S7yGFBuk2jcGCdgL0;
			}

			// Token: 0x02000E54 RID: 3668
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<AcquaintanceServersResponse.Types.Error>, IMessage, IEquatable<AcquaintanceServersResponse.Types.Error>, IDeepCloneable<AcquaintanceServersResponse.Types.Error>, IBufferMessage
			{
				// Token: 0x170020A2 RID: 8354
				// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x00310384 File Offset: 0x0030E584
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<AcquaintanceServersResponse.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170020A3 RID: 8355
				// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x00310394 File Offset: 0x0030E594
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

				// Token: 0x170020A4 RID: 8356
				// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x003103A4 File Offset: 0x0030E5A4
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

				// Token: 0x0600AFF6 RID: 45046 RVA: 0x003103B4 File Offset: 0x0030E5B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x0600AFF7 RID: 45047 RVA: 0x003103C4 File Offset: 0x0030E5C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(AcquaintanceServersResponse.Types.Error other)
				{
				}

				// Token: 0x0600AFF8 RID: 45048 RVA: 0x003103D4 File Offset: 0x0030E5D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AcquaintanceServersResponse.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x170020A5 RID: 8357
				// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x003103E4 File Offset: 0x0030E5E4
				// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x003103F8 File Offset: 0x0030E5F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public AcquaintanceServersResponse.Types.Error.Types.Reason Reason
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (AcquaintanceServersResponse.Types.Error.Types.Reason)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x0600AFFB RID: 45051 RVA: 0x00310408 File Offset: 0x0030E608
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AFFC RID: 45052 RVA: 0x00310418 File Offset: 0x0030E618
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AcquaintanceServersResponse.Types.Error other)
				{
					return true;
				}

				// Token: 0x0600AFFD RID: 45053 RVA: 0x00310428 File Offset: 0x0030E628
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AFFE RID: 45054 RVA: 0x00310438 File Offset: 0x0030E638
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AFFF RID: 45055 RVA: 0x00310448 File Offset: 0x0030E648
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600B000 RID: 45056 RVA: 0x00310458 File Offset: 0x0030E658
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600B001 RID: 45057 RVA: 0x00310468 File Offset: 0x0030E668
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600B002 RID: 45058 RVA: 0x00310478 File Offset: 0x0030E678
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AcquaintanceServersResponse.Types.Error other)
				{
				}

				// Token: 0x0600B003 RID: 45059 RVA: 0x00310488 File Offset: 0x0030E688
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600B004 RID: 45060 RVA: 0x00310498 File Offset: 0x0030E698
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600B005 RID: 45061 RVA: 0x003104A8 File Offset: 0x0030E6A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							default:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
								{
									num2 = 4;
								}
								break;
							case 1:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
								{
									num2 = 1;
								}
								break;
							case 3:
								return;
							case 4:
								goto IL_5E;
							}
						}
						IL_5E:
						AcquaintanceServersResponse.Types.Error._parser = new MessageParser<AcquaintanceServersResponse.Types.Error>(() => null);
						num = 3;
					}
				}

				// Token: 0x0600B006 RID: 45062 RVA: 0x00310590 File Offset: 0x0030E790
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool SLISQBGFODCZ2Vw0K3Oy()
				{
					return true;
				}

				// Token: 0x0600B007 RID: 45063 RVA: 0x00310598 File Offset: 0x0030E798
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AcquaintanceServersResponse.Types.Error j9mA0tGFJFQJh2HFa6O0()
				{
					return null;
				}

				// Token: 0x040040DB RID: 16603
				private static readonly MessageParser<AcquaintanceServersResponse.Types.Error> _parser;

				// Token: 0x040040DC RID: 16604
				private UnknownFieldSet _unknownFields;

				// Token: 0x040040DD RID: 16605
				public const int ReasonFieldNumber = 1;

				// Token: 0x040040DE RID: 16606
				private AcquaintanceServersResponse.Types.Error.Types.Reason reason_;

				// Token: 0x040040DF RID: 16607
				private static AcquaintanceServersResponse.Types.Error Y0UncmGFRjMNrpZV1AhT;

				// Token: 0x02000E55 RID: 3669
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600B008 RID: 45064 RVA: 0x0031AFE0 File Offset: 0x003191E0
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000E56 RID: 3670
					public enum Reason
					{
						// Token: 0x040040E1 RID: 16609
						[OriginalName("UNKNOWN")]
						Unknown,
						// Token: 0x040040E2 RID: 16610
						[OriginalName("NO_RESULT")]
						NoResult,
						// Token: 0x040040E3 RID: 16611
						[OriginalName("FLOOD")]
						Flood,
						// Token: 0x040040E4 RID: 16612
						[OriginalName("INVALID_ACCOUNT")]
						InvalidAccount
					}
				}
			}
		}
	}
}
