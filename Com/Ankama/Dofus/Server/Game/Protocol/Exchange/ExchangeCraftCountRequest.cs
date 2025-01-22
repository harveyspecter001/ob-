using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006E0 RID: 1760
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftCountRequest : IMessage<ExchangeCraftCountRequest>, IMessage, IEquatable<ExchangeCraftCountRequest>, IDeepCloneable<ExchangeCraftCountRequest>, IBufferMessage
	{
		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x00213484 File Offset: 0x00211684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeCraftCountRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x00213494 File Offset: 0x00211694
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x002134A4 File Offset: 0x002116A4
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

		// Token: 0x06005619 RID: 22041 RVA: 0x002134B4 File Offset: 0x002116B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountRequest()
		{
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x002134C4 File Offset: 0x002116C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountRequest(ExchangeCraftCountRequest other)
		{
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x002134D4 File Offset: 0x002116D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x002134E4 File Offset: 0x002116E4
		// (set) Token: 0x0600561D RID: 22045 RVA: 0x002134F4 File Offset: 0x002116F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
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

		// Token: 0x0600561E RID: 22046 RVA: 0x00213504 File Offset: 0x00211704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00213514 File Offset: 0x00211714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftCountRequest other)
		{
			return true;
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00213524 File Offset: 0x00211724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00213534 File Offset: 0x00211734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x00213544 File Offset: 0x00211744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00213554 File Offset: 0x00211754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00213564 File Offset: 0x00211764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00213574 File Offset: 0x00211774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftCountRequest other)
		{
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x00213584 File Offset: 0x00211784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00213594 File Offset: 0x00211794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x002135A4 File Offset: 0x002117A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftCountRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				ExchangeCraftCountRequest._parser = new MessageParser<ExchangeCraftCountRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00213670 File Offset: 0x00211870
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CEh9OqOMcYX8MKgASXAT()
		{
			return true;
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00213678 File Offset: 0x00211878
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftCountRequest LAS0t0OMUVi5O2Fo9Njf()
		{
			return null;
		}

		// Token: 0x04001E37 RID: 7735
		private static readonly MessageParser<ExchangeCraftCountRequest> _parser;

		// Token: 0x04001E38 RID: 7736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E39 RID: 7737
		public const int CountFieldNumber = 1;

		// Token: 0x04001E3A RID: 7738
		private int count_;

		// Token: 0x04001E3B RID: 7739
		internal static ExchangeCraftCountRequest KWdBhdOMl0gmOKksnUJS;
	}
}
