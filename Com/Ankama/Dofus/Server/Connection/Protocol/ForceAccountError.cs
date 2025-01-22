using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E38 RID: 3640
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForceAccountError : IMessage<ForceAccountError>, IMessage, IEquatable<ForceAccountError>, IDeepCloneable<ForceAccountError>, IBufferMessage
	{
		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x002A0A50 File Offset: 0x0029EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForceAccountError> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600AEE2 RID: 44770 RVA: 0x002A0A60 File Offset: 0x0029EC60
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x002A0A70 File Offset: 0x0029EC70
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

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x002A0A80 File Offset: 0x0029EC80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountError()
		{
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x002A0A90 File Offset: 0x0029EC90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountError(ForceAccountError other)
		{
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x002A0AA0 File Offset: 0x0029ECA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountError Clone()
		{
			return null;
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x002A0AB0 File Offset: 0x0029ECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x002A0AC0 File Offset: 0x0029ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForceAccountError other)
		{
			return true;
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x002A0AD0 File Offset: 0x0029ECD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x002A0AE0 File Offset: 0x0029ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AEEB RID: 44779 RVA: 0x002A0AF0 File Offset: 0x0029ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x002A0B00 File Offset: 0x0029ED00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x002A0B10 File Offset: 0x0029ED10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x002A0B20 File Offset: 0x0029ED20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForceAccountError other)
		{
		}

		// Token: 0x0600AEEF RID: 44783 RVA: 0x002A0B30 File Offset: 0x0029ED30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x002A0B40 File Offset: 0x0029ED40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x002A0B50 File Offset: 0x0029ED50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForceAccountError()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
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
					ForceAccountError._parser = new MessageParser<ForceAccountError>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x002A0C34 File Offset: 0x0029EE34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b2XNSlJvEAu52iSKu17l()
		{
			return true;
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x002A0C3C File Offset: 0x0029EE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForceAccountError OxHi10JvXXcp50BeOgIX()
		{
			return null;
		}

		// Token: 0x04004066 RID: 16486
		private static readonly MessageParser<ForceAccountError> _parser;

		// Token: 0x04004067 RID: 16487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004068 RID: 16488
		internal static ForceAccountError dVnAM9Jv2o0wpj4X9b1n;
	}
}
