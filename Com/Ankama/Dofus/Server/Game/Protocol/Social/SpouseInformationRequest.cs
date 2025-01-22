using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200013F RID: 319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpouseInformationRequest : IMessage<SpouseInformationRequest>, IMessage, IEquatable<SpouseInformationRequest>, IDeepCloneable<SpouseInformationRequest>, IBufferMessage
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0019BD80 File Offset: 0x00199F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SpouseInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0019BD90 File Offset: 0x00199F90
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0019BDA0 File Offset: 0x00199FA0
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

		// Token: 0x06000E80 RID: 3712 RVA: 0x0019BDB0 File Offset: 0x00199FB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationRequest()
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0019BDC0 File Offset: 0x00199FC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationRequest(SpouseInformationRequest other)
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0019BDD0 File Offset: 0x00199FD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0019BDE0 File Offset: 0x00199FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0019BDF0 File Offset: 0x00199FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpouseInformationRequest other)
		{
			return true;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0019BE00 File Offset: 0x0019A000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0019BE10 File Offset: 0x0019A010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0019BE20 File Offset: 0x0019A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0019BE30 File Offset: 0x0019A030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0019BE40 File Offset: 0x0019A040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0019BE50 File Offset: 0x0019A050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpouseInformationRequest other)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0019BE60 File Offset: 0x0019A060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0019BE70 File Offset: 0x0019A070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0019BE80 File Offset: 0x0019A080
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpouseInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SpouseInformationRequest._parser = new MessageParser<SpouseInformationRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0019BF64 File Offset: 0x0019A164
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YLZs1yOURxSaX9miyn5F()
		{
			return true;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0019BF6C File Offset: 0x0019A16C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpouseInformationRequest cmbkfuOUOZ6sZcVqasAB()
		{
			return null;
		}

		// Token: 0x04000549 RID: 1353
		private static readonly MessageParser<SpouseInformationRequest> _parser;

		// Token: 0x0400054A RID: 1354
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400054B RID: 1355
		internal static SpouseInformationRequest dW0AVMOU38X1v315uhI1;
	}
}
