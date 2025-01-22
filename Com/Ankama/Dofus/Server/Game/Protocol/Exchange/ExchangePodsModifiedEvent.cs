using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000727 RID: 1831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangePodsModifiedEvent : IMessage<ExchangePodsModifiedEvent>, IMessage, IEquatable<ExchangePodsModifiedEvent>, IDeepCloneable<ExchangePodsModifiedEvent>, IBufferMessage
	{
		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x00217B8C File Offset: 0x00215D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangePodsModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x00217B9C File Offset: 0x00215D9C
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

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x00217BAC File Offset: 0x00215DAC
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

		// Token: 0x060059B1 RID: 22961 RVA: 0x00217BBC File Offset: 0x00215DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePodsModifiedEvent()
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00217BCC File Offset: 0x00215DCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePodsModifiedEvent(ExchangePodsModifiedEvent other)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00217BDC File Offset: 0x00215DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePodsModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x00217BEC File Offset: 0x00215DEC
		// (set) Token: 0x060059B5 RID: 22965 RVA: 0x00217BFC File Offset: 0x00215DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Remote
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

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x00217C0C File Offset: 0x00215E0C
		// (set) Token: 0x060059B7 RID: 22967 RVA: 0x00217C1C File Offset: 0x00215E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentWeight
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

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x00217C2C File Offset: 0x00215E2C
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x00217C3C File Offset: 0x00215E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxWeight
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

		// Token: 0x060059BA RID: 22970 RVA: 0x00217C4C File Offset: 0x00215E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00217C5C File Offset: 0x00215E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangePodsModifiedEvent other)
		{
			return true;
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00217C6C File Offset: 0x00215E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00217C7C File Offset: 0x00215E7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00217C8C File Offset: 0x00215E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00217C9C File Offset: 0x00215E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00217CAC File Offset: 0x00215EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x00217CBC File Offset: 0x00215EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangePodsModifiedEvent other)
		{
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00217CCC File Offset: 0x00215ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00217CDC File Offset: 0x00215EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x00217CEC File Offset: 0x00215EEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangePodsModifiedEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangePodsModifiedEvent._parser = new MessageParser<ExchangePodsModifiedEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00217DD0 File Offset: 0x00215FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lMhE66O8ng9Ls7VFpr7p()
		{
			return true;
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x00217DD8 File Offset: 0x00215FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangePodsModifiedEvent uW6f1BO8mwrdlK2aC43q()
		{
			return null;
		}

		// Token: 0x04001F67 RID: 8039
		private static readonly MessageParser<ExchangePodsModifiedEvent> _parser;

		// Token: 0x04001F68 RID: 8040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F69 RID: 8041
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F6A RID: 8042
		private bool remote_;

		// Token: 0x04001F6B RID: 8043
		public const int CurrentWeightFieldNumber = 2;

		// Token: 0x04001F6C RID: 8044
		private int currentWeight_;

		// Token: 0x04001F6D RID: 8045
		public const int MaxWeightFieldNumber = 3;

		// Token: 0x04001F6E RID: 8046
		private int maxWeight_;

		// Token: 0x04001F6F RID: 8047
		internal static ExchangePodsModifiedEvent Cf0K6RO8fdIJBlDsinsI;
	}
}
