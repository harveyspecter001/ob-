using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001A1 RID: 417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuideModReturnRequest : IMessage<GuideModReturnRequest>, IMessage, IEquatable<GuideModReturnRequest>, IDeepCloneable<GuideModReturnRequest>, IBufferMessage
	{
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x001A45BC File Offset: 0x001A27BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuideModReturnRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x001A45CC File Offset: 0x001A27CC
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x001A45DC File Offset: 0x001A27DC
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

		// Token: 0x06001361 RID: 4961 RVA: 0x001A45EC File Offset: 0x001A27EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModReturnRequest()
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x001A45FC File Offset: 0x001A27FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModReturnRequest(GuideModReturnRequest other)
		{
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x001A460C File Offset: 0x001A280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModReturnRequest Clone()
		{
			return null;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x001A461C File Offset: 0x001A281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x001A462C File Offset: 0x001A282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuideModReturnRequest other)
		{
			return true;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x001A463C File Offset: 0x001A283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x001A464C File Offset: 0x001A284C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x001A465C File Offset: 0x001A285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x001A466C File Offset: 0x001A286C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x001A467C File Offset: 0x001A287C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x001A468C File Offset: 0x001A288C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuideModReturnRequest other)
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x001A469C File Offset: 0x001A289C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x001A46AC File Offset: 0x001A28AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x001A46BC File Offset: 0x001A28BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuideModReturnRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					GuideModReturnRequest._parser = new MessageParser<GuideModReturnRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x001A47A0 File Offset: 0x001A29A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iw4SkDOokJh0o5G3x4Yt()
		{
			return true;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x001A47A8 File Offset: 0x001A29A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuideModReturnRequest OL4e3dOolGlyJE6ZLBoY()
		{
			return null;
		}

		// Token: 0x040006F6 RID: 1782
		private static readonly MessageParser<GuideModReturnRequest> _parser;

		// Token: 0x040006F7 RID: 1783
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006F8 RID: 1784
		private static GuideModReturnRequest IwmCH8OoIbowMjjOckyG;
	}
}
