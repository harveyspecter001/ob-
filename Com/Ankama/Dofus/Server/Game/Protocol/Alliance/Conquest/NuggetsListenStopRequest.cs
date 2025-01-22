using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DA9 RID: 3497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NuggetsListenStopRequest : IMessage<NuggetsListenStopRequest>, IMessage, IEquatable<NuggetsListenStopRequest>, IDeepCloneable<NuggetsListenStopRequest>, IBufferMessage
	{
		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600A88D RID: 43149 RVA: 0x0029553C File Offset: 0x0029373C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NuggetsListenStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x0029554C File Offset: 0x0029374C
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x0600A88F RID: 43151 RVA: 0x0029555C File Offset: 0x0029375C
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

		// Token: 0x0600A890 RID: 43152 RVA: 0x0029556C File Offset: 0x0029376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStopRequest()
		{
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x0029557C File Offset: 0x0029377C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStopRequest(NuggetsListenStopRequest other)
		{
		}

		// Token: 0x0600A892 RID: 43154 RVA: 0x0029558C File Offset: 0x0029378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStopRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x0029559C File Offset: 0x0029379C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x002955AC File Offset: 0x002937AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NuggetsListenStopRequest other)
		{
			return true;
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x002955BC File Offset: 0x002937BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x002955CC File Offset: 0x002937CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x002955DC File Offset: 0x002937DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x002955EC File Offset: 0x002937EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x002955FC File Offset: 0x002937FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x0029560C File Offset: 0x0029380C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NuggetsListenStopRequest other)
		{
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x0029561C File Offset: 0x0029381C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x0029562C File Offset: 0x0029382C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x0029563C File Offset: 0x0029383C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NuggetsListenStopRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					NuggetsListenStopRequest._parser = new MessageParser<NuggetsListenStopRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A89E RID: 43166 RVA: 0x00295734 File Offset: 0x00293934
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SHS88dJltPqq9d83FXQ9()
		{
			return true;
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x0029573C File Offset: 0x0029393C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NuggetsListenStopRequest wws0KbJlwu2UNEBrmtaQ()
		{
			return null;
		}

		// Token: 0x04003DFF RID: 15871
		private static readonly MessageParser<NuggetsListenStopRequest> _parser;

		// Token: 0x04003E00 RID: 15872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E01 RID: 15873
		internal static NuggetsListenStopRequest eL5DBgJlDiOOI40S228J;
	}
}
