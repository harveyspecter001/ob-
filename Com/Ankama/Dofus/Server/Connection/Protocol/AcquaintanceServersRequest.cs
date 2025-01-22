using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E4D RID: 3661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceServersRequest : IMessage<AcquaintanceServersRequest>, IMessage, IEquatable<AcquaintanceServersRequest>, IDeepCloneable<AcquaintanceServersRequest>, IBufferMessage
	{
		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x002A1500 File Offset: 0x0029F700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcquaintanceServersRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600AFA5 RID: 44965 RVA: 0x002A1510 File Offset: 0x0029F710
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

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x002A1520 File Offset: 0x0029F720
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

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x002A1530 File Offset: 0x0029F730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersRequest()
		{
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x002A1540 File Offset: 0x0029F740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersRequest(AcquaintanceServersRequest other)
		{
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x002A1550 File Offset: 0x0029F750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceServersRequest Clone()
		{
			return null;
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x002A1560 File Offset: 0x0029F760
		// (set) Token: 0x0600AFAB RID: 44971 RVA: 0x002A1570 File Offset: 0x0029F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x002A1580 File Offset: 0x0029F780
		// (set) Token: 0x0600AFAD RID: 44973 RVA: 0x002A1590 File Offset: 0x0029F790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Tag
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

		// Token: 0x0600AFAE RID: 44974 RVA: 0x002A15A0 File Offset: 0x0029F7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x002A15B0 File Offset: 0x0029F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceServersRequest other)
		{
			return true;
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x002A15C0 File Offset: 0x0029F7C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AFB1 RID: 44977 RVA: 0x002A15D0 File Offset: 0x0029F7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x002A15E0 File Offset: 0x0029F7E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x002A15F0 File Offset: 0x0029F7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x002A1600 File Offset: 0x0029F800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x002A1610 File Offset: 0x0029F810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceServersRequest other)
		{
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x002A1620 File Offset: 0x0029F820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x002A1630 File Offset: 0x0029F830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x002A1640 File Offset: 0x0029F840
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceServersRequest()
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
						goto IL_35;
					case 2:
						AcquaintanceServersRequest._parser = new MessageParser<AcquaintanceServersRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x002A1728 File Offset: 0x0029F928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FOls1AJvaEg4Kmp93r1K()
		{
			return true;
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x002A1730 File Offset: 0x0029F930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceServersRequest w57yyEJv5fQMSOe055AU()
		{
			return null;
		}

		// Token: 0x040040BF RID: 16575
		private static readonly MessageParser<AcquaintanceServersRequest> _parser;

		// Token: 0x040040C0 RID: 16576
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040C1 RID: 16577
		public const int NameFieldNumber = 1;

		// Token: 0x040040C2 RID: 16578
		private string name_;

		// Token: 0x040040C3 RID: 16579
		public const int TagFieldNumber = 2;

		// Token: 0x040040C4 RID: 16580
		private string tag_;

		// Token: 0x040040C5 RID: 16581
		internal static AcquaintanceServersRequest fYs2dTJv1fjYTm0frs3Q;
	}
}
